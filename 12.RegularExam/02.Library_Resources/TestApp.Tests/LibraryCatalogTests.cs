using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        this._catalog = new();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        _catalog.AddBook("25AE0Y1", "Capitan Hook", "Ivan Mitev");
        _catalog.AddBook("14AULY1", "Dark Shadow", "Todor Ivanov");

        string expected = "Library Catalog:" + Environment.NewLine + "Capitan Hook by Ivan Mitev (ISBN: 25AE0Y1)" + Environment.NewLine + "Dark Shadow by Todor Ivanov (ISBN: 14AULY1)";

        string result = _catalog.DisplayCatalog();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        _catalog.AddBook("EEAETYT", "Capitan Hook", "Ivan Mitev");
        _catalog.AddBook("14AULY1", "Dark Shadow", "Todor Ivanov");


        string expected = "Library Catalog:" + Environment.NewLine
                                             + "Capitan Hook by Ivan Mitev (ISBN: EEAETYT)";




        Book addedBook = _catalog.GetBook("EEAETYT");

        Assert.That(addedBook, Is.Not.Null);
        Assert.That(addedBook.Isbn, Is.EqualTo("EEAETYT"));
        Assert.That(addedBook.Title, Is.EqualTo("Capitan Hook"));
        Assert.That(addedBook.Author, Is.EqualTo("Ivan Mitev"));



    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        string isbn = "25AE0Y1";
        string title = "Capitan Hook";
        string author = "Ivan Mitev";

        _catalog.AddBook(isbn, title, author);

        Assert.That(() => _catalog.GetBook("A10HRT"), Throws.ArgumentException);

    }

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        string expected = String.Empty;
        string result = _catalog.DisplayCatalog();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {

        _catalog.AddBook("25AE0Y1", "Capitan Hook", "Ivan Mitev");
        _catalog.AddBook("14AULY1", "Dark Shadow", "Todor Ivanov");
        _catalog.AddBook("PO5TLR3", "Do not give up", "Dimitar Kolev");


        string expected = "Library Catalog:" + Environment.NewLine
                                             + "Capitan Hook by Ivan Mitev (ISBN: 25AE0Y1)"
                                             + Environment.NewLine
                                             + "Dark Shadow by Todor Ivanov (ISBN: 14AULY1)"
                                             + Environment.NewLine
                                             + "Do not give up by Dimitar Kolev (ISBN: PO5TLR3)";

        string result = _catalog.DisplayCatalog();

        Assert.That(result, Is.EqualTo(expected));
    }
}
