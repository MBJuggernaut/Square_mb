using NUnit.Framework;

namespace Square_mb_TestProject
{
    public class CircleTests
    {
        [Test]
        public void GetSquare()
        {
            //Arrange
            double r = 3;
            IFigure figure = new Circle(r);
            double estimatedSquare = Math.Pow(r, 2) * Math.PI;
            //Act
            double square = figure.GetSquare();
            //Assert
            Assert.That(estimatedSquare, Is.EqualTo(square));
        }

        [TestCase(0)]
        [TestCase(-5)]
        public void CreateExemplar_WrongIncoming(double r)
        {
            //Arrange
            IFigure? figure = null;
            bool hasCatchedError = false;
            //Act
            try
            {
                figure = new Circle(r);
            }
            catch
            {
                hasCatchedError = true;
            }
            //Assert
            Assert.IsNull(figure);
            Assert.IsTrue(hasCatchedError);
        }
    }
}