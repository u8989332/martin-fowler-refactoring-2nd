using System;
using System.Collections.Generic;
using System.IO;
using ExtractFunction.Core;
using NUnit.Framework;

namespace ExtractFunction.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_NoVariablesOutOfScope_Return_Correct_Details()
        {
            // arrange
            NoVariablesOutOfScope example = new NoVariablesOutOfScope(new StaticClock());
            WorkLoading workLoading = new WorkLoading()
            {
                Name = "John",
                Projects = new List<Project>()
                {
                    new Project()
                    {
                        Progress = 70
                    },
                    new Project()
                    {
                        Progress = 40
                    }
                }
            };


            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            // act
            example.PrintWorkLoading(workLoading);

            // assert
            Assert.AreEqual(
                @"*************
** Loading **
*************
name: John
progress: 110
due: 01/31/2022
", sw.ToString());
        }

        [Test]
        public void Test_UsingLocalVariables_Return_Correct_Details()
        {
            // arrange
            UsingLocalVariables example = new UsingLocalVariables(new StaticClock());
            WorkLoading workLoading = new WorkLoading()
            {
                Name = "John",
                Projects = new List<Project>()
                {
                    new Project()
                    {
                        Progress = 70
                    },
                    new Project()
                    {
                        Progress = 40
                    }
                }
            };


            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            // act
            example.PrintWorkLoading(workLoading);

            // assert
            Assert.AreEqual(
                @"*************
** Loading **
*************
name: John
progress: 110
due: 01/31/2022
", sw.ToString());
        }

        [Test]
        public void Test_ReassigningALocalVariable_Return_Correct_Details()
        {
            // arrange
            ReassigningALocalVariable example = new ReassigningALocalVariable(new StaticClock());
            WorkLoading workLoading = new WorkLoading()
            {
                Name = "John",
                Projects = new List<Project>()
                {
                    new Project()
                    {
                        Progress = 70
                    },
                    new Project()
                    {
                        Progress = 40
                    }
                }
            };


            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            // act
            example.PrintWorkLoading(workLoading);

            // assert
            Assert.AreEqual(
                @"*************
** Loading **
*************
name: John
progress: 110
due: 01/31/2022
", sw.ToString());
        }
    }

    public class StaticClock : IClock
    {
        public DateTime Now => new DateTime(2022, 1, 1);
    }
}