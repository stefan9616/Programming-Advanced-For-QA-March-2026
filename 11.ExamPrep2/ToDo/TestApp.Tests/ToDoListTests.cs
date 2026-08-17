using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        _toDoList.AddTask("Task1", DateTime.Now);
        string expected = "To-Do List:" + Environment.NewLine + "[ ] Task1 - Due: 04/14/2026";

        //Act
        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        _toDoList.AddTask("Task1", DateTime.Now);
        _toDoList.CompleteTask("Task1");

        string expected = "To-Do List:" + Environment.NewLine + "[✓] Task1 - Due: 04/14/2026";

        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        _toDoList.AddTask("Task1", DateTime.Now);

        Assert.That(() => _toDoList.CompleteTask("InvalidTask"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        string expected = "To-Do List:";
        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        _toDoList.AddTask("Task1", DateTime.Now);
        _toDoList.CompleteTask("Task1");

        _toDoList.AddTask("Task2", DateTime.Now);
        _toDoList.AddTask("Task3", DateTime.Now);
        _toDoList.AddTask("Task4", DateTime.Now);
        _toDoList.CompleteTask("Task3");

        string expected = "To-Do List:" + Environment.NewLine + "[✓] Task1 - Due: 04/14/2026"
                                        + Environment.NewLine + "[ ] Task2 - Due: 04/14/2026"
                                        + Environment.NewLine + "[✓] Task3 - Due: 04/14/2026"
                                        + Environment.NewLine + "[ ] Task4 - Due: 04/14/2026";

        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo(expected));

    }
}
