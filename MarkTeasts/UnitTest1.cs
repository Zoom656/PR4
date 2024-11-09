using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Podschet_Ballov;
namespace MarkTeasts
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            int marka = 6;
            int markb = 5;
            int markc = 4;
            int sum1 = 0;
            
            
            // Act
            try
            {
                
            }
            catch (System.ArgumentOutOfRangeException e)
            {
               
              Console.WriteLine(e.Message);
                return;
            }

        }

    }
}
