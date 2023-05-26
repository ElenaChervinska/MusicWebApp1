using Microsoft.AspNetCore.Mvc;
using MusicWebApp1.Controllers;

namespace Test;

public class HomeControllerTests
{
    [Test]
    public void IndexViewDataMessage()
    {
        HomeController controller = new HomeController();
        ViewResult? result = controller.Index() as ViewResult;
        Assert.That(result?.ViewData["Message"], Is.EqualTo("Hello World!"));
    }

    [Test]
    public void IndexViewResultNotNull()
    {
        HomeController controller = new HomeController();
        ViewResult? result = controller.Index() as ViewResult;
        Assert.That(result, Is.Not.Null);
    }

    [Test]
    public void IndexViewNameEqualIndex()
    {
        HomeController controller = new HomeController();
        ViewResult? result = controller.Index() as ViewResult;
        Assert.That(result?.ViewName, Is.EqualTo("Index"));
    }
}
