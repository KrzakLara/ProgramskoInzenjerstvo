using NUnit.Framework;
using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.Models.Train;

namespace SOLID.Testing
{
   
    public class UnitTest
    {
        [Test]
        public void TestTrainSize()
        {
            Train mini_train = new Train(SizeOfTheTrain.Mini);
            Train maxi_train = new Train(SizeOfTheTrain.Maxi);



            Assert.AreEqual(mini_train.GetSize(), SizeOfTheTrain.Mini);
            Console.WriteLine("Test 1 successful");

            Assert.AreEqual(mini_train.GetSize(), 6);
            Console.WriteLine("Test 2 successful");


            Assert.AreEqual(maxi_train.GetCapacity(), SizeOfTheTrain.Maxi);
            Console.WriteLine("Test 3 successful");


            Assert.AreEqual(maxi_train.GetCapacity(), 8);
            Console.WriteLine("Test 4 successful");



        }
    }
}
