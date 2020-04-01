using System;
using System.Text.RegularExpressions;
using NFluent;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ExploreCsharpEight.Tests
{
    [TestFixture]
    public class RegularExpressionShould
    {
        [TestCase("toto 15", true)]
        [TestCase("toto6966 15", true)]
        [TestCase("toto6966 15d", false)]
        [TestCase("toto6966     15", true)]
        [TestCase("42 15", true)]
        public void Match_string_space_integer(string input, bool expectedMatch)
        {
            var regex = new Regex(@"^\w+\s+\d+$");
            bool match = regex.IsMatch(input);

            Check.That(match).IsEqualTo(expectedMatch);
        }

        [Test]
        public void Match_one_value()
        {
            // Step 1: create new Regex.
            Regex regex = new Regex(@"\d+");

            // Step 2: call Match on Regex instance.
            Match match = regex.Match("Dot 55 Perls");

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("MATCH VALUE: " + match.Value);
            }
        }

        [Test]
        public void Take_out_matching_values()
        {
            // Part 1: the input string.
            string input = "/content/alternate-1.aspx";

            // Part 2: call Regex.Match.
            Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
                RegexOptions.IgnoreCase);

            // Part 3: check the Match for Success.
            if(!match.Success)
                Assert.Fail("Not match");


            // Part 4: get the Group value and display it.
            Check.That(match.Groups).HasSize(2);

            Check.That(match.Groups[0].Value).IsEqualTo("content/alternate-1.aspx");
            Check.That(match.Groups[1].Value).IsEqualTo("alternate-1");
        }
    }
}