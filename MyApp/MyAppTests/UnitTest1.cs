using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenIsLoopTopExecuted()
        {
            var testLoopCounter = 0;
            var testTopCounter = 0;
            var length = 100;
            var text = "Hello, Las Vegas".ToList();

            for (var i = 0; i < (GetRepeatCount(length, text)); i++)
            {
                testLoopCounter++;
            }

            Assert.IsTrue(false);

            int GetRepeatCount(int length, List<char> text)
            {
                testTopCounter++;
                return length >= text.Count()
                                         ? length / text.Count()
                                         : 1;
            }
        }

        [TestMethod]
        public void HowManyTimeLinqExecutes()
        {
            var testLoopCounter = 0;

            var list = Enumerable.Range(1, 10);
            var list2 = list.Where(x=> DBAccessById(x)).ToList();

            Assert.IsTrue(false);

            bool DBAccessById(int i)
            {
                testLoopCounter++;
                return true;
            }
        }


        [TestMethod]
        public void ShortInShortOut()
        {
            var text = "Hello";
            var length = 10;
            var filler = new StringFiller();
            var output = filler.GetString(text, length);
            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void LongInLongOut()
        {
            var text = Gettysburg_long;
            var length = 10_000;
            var filler = new StringFiller();
            var output = filler.GetString(text, length);
            Assert.IsNotNull(output);
        }

        // This is a little less than 1,500 characters
        private readonly string _gettysburg = "Fourscore and seven years ago our fathers brought forth, on this continent, a new nation, conceived in liberty, and dedicated to the proposition that all men are created equal.Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived, and so dedicated, can long endure.We are met on a great battle-field of that war. We have come to dedicate a portion of that field, as a final resting-place for those who here gave their lives, that that nation might live.It is altogether fitting and proper that we should do this. But, in a larger sense, we cannot dedicate, we cannot consecrate�we cannot hallow�this ground.The brave men, living and dead, who struggled here, have consecrated it far above our poor power to add or detract. The world will little note, nor long remember what we say here, but it can never forget what they did here.It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced.It is rather for us to be here dedicated to the great task remaining before us�that from these honored dead we take increased devotion to that cause for which they here gave the last full measure of devotion�that we here highly resolve that these dead shall not have died in vain�that this nation, under God, shall have a new birth of freedom, and that government of the people, by the people, for the people, shall not perish from the earth.";

        private string Gettysburg_long =>
           String.Join('|', Enumerable.Range(0, 20)
              .Select(x => _gettysburg));

    }

}
