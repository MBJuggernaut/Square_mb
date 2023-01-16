using NUnit.Framework;

namespace Square_mb_TestProject
{
    public class TriangleTests
    {
        [Test]
        public void GetSquare()
        {
            //Arrange
            IFigure figure = new Triangle(3, 4, 5);
            double estimatedSquare = 6;

            //Act
            double square = figure.GetSquare();

            //Assert
            Assert.That(estimatedSquare, Is.EqualTo(square));
        }

        [TestCase(0, 3, 4)]
        [TestCase(3, 0, 6)]
        [TestCase(4, 4, 0)]
        public void CreatingExeplar_WrongIncoming(double a, double b, double c)
        {
            //Arrange
            IFigure? figure = null;
            bool catchedError = false;

            //Act
            try
            {
                figure = new Triangle(a, b, c);
            }
            catch 
            {
                catchedError = true;
            }

            //Assert
            Assert.IsNull(figure);
            Assert.IsTrue(catchedError);
        }
    }
}