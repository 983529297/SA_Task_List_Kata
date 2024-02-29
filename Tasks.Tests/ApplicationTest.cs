using System;
using System.IO;
using NUnit.Framework;

namespace Tasks
{
	[TestFixture]
	public sealed class ApplicationTest
	{
		public const string PROMPT = "> ";

		private FakeConsole console;
		private System.Threading.Thread applicationThread;

		[SetUp]
		public void StartTheApplication()
		{
			this.console = new FakeConsole();
			var taskList = new TaskList(console);
			this.applicationThread = new System.Threading.Thread(() => taskList.Run());
			applicationThread.Start();
		}

		[TearDown]
		public void KillTheApplication()
		{
			if (applicationThread == null || !applicationThread.IsAlive)
			{
				return;
			}

			applicationThread.Abort();
			throw new Exception("The application is still running.");
		}

		[Test, Timeout(1000)]
		public void ItWorks()
		{
			Execute("show");

			Execute("add project secrets");
			Execute("add task secrets Eat more donuts.");
			Execute("add task secrets Destroy all humans.");

            Execute("show");
            ReadLines(
                "secrets",
                "    [ ] 1: Eat more donuts.",
                "    [ ] 2: Destroy all humans.",
                ""
            );

            Execute("add project training");
            Execute("add task training Four Elements of Simple Design");
            Execute("add task training SOLID");
            Execute("add task training Coupling and Cohesion");
            Execute("add task training Primitive Obsession");
            Execute("add task training Outside-In TDD");
            Execute("add task training Interaction-Driven Design");

            Execute("check 1");
            Execute("check 3");
            Execute("check 5");
            Execute("check 6");

            Execute("show");
            ReadLines(
                "secrets",
                "    [x] 1: Eat more donuts.",
                "    [ ] 2: Destroy all humans.",
                "",
                "training",
                "    [x] 3: Four Elements of Simple Design",
                "    [ ] 4: SOLID",
                "    [x] 5: Coupling and Cohesion",
                "    [x] 6: Primitive Obsession",
                "    [ ] 7: Outside-In TDD",
                "    [ ] 8: Interaction-Driven Design",
                ""
            );
			Execute("deadline 1 " + DateTime.Now.Date);
			Execute("deadline 7 " + DateTime.Now.Date);
			Execute("deadline 4 2023-2-28");

			Execute("show");
			ReadLines(
				"secrets",
				"    [x] 1: Eat more donuts. " + DateTime.Now.ToString("yyyy-MM-dd"),
				"    [ ] 2: Destroy all humans.",
				"",
				"training",
				"    [x] 3: Four Elements of Simple Design",
				"    [ ] 4: SOLID 2023-02-28",
				"    [x] 5: Coupling and Cohesion",
				"    [x] 6: Primitive Obsession",
				"    [ ] 7: Outside-In TDD " + DateTime.Now.ToString("yyyy-MM-dd"),
				"    [ ] 8: Interaction-Driven Design",
				""
			);

			Execute("today");
			ReadLines(
				"secrets",
				"    [x] 1: Eat more donuts. " + DateTime.Now.ToString("yyyy-MM-dd"),
				"",
				"training",
				"    [ ] 7: Outside-In TDD " + DateTime.Now.ToString("yyyy-MM-dd"),
				""
			);

			Execute("delete 1");
			Execute("show");
			ReadLines(
				"secrets",
				"    [ ] 2: Destroy all humans.",
				"",
				"training",
				"    [x] 3: Four Elements of Simple Design",
				"    [ ] 4: SOLID 2023-02-28",
				"    [x] 5: Coupling and Cohesion",
				"    [x] 6: Primitive Obsession",
				"    [ ] 7: Outside-In TDD " + DateTime.Now.ToString("yyyy-MM-dd"),
				"    [ ] 8: Interaction-Driven Design",
				""
			);

			Execute("today");
			ReadLines(
				"training",
				"    [ ] 7: Outside-In TDD " + DateTime.Now.ToString("yyyy-MM-dd"),
				""
			);

			Execute("help");
			ReadLines(
				"Commands:",
				"  show",
				"  view by project",
				"  view by deadline",
				"  view by date",
				"  add project <project name>",
				"  add task <project name> <task description>",
				"  deadline <task ID> <yyyy-MM-dd>",
				"  today",
				"  check <task ID>",
				"  uncheck <task ID>",
				""
			);

			Execute("quit");
		}

		private void Execute(string command)
		{
			Read(PROMPT);
			Write(command);
		}

		private void Read(string expectedOutput)
		{
			var length = expectedOutput.Length;
			var actualOutput = console.RetrieveOutput(expectedOutput.Length);
			Assert.AreEqual(expectedOutput, actualOutput);
		}

		private void ReadLines(params string[] expectedOutput)
		{
			foreach (var line in expectedOutput)
			{
				Read(line + Environment.NewLine);
			}
		}

		private void Write(string input)
		{
			console.SendInput(input + Environment.NewLine);
		}
	}
}
