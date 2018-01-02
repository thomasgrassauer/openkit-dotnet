﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dynatrace.OpenKit.Core
{
    class DefaultLoggerTest
    {
        [Test]
        public void DefaultLoggerWithVerboseOutputWritesErrorLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(true);

            //then
            Assert.That(log.ErrorEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithVerboseOutputWritesWarnLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(true);

            //then
            Assert.That(log.WarnEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithVerboseOutputWritesInfoLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(true);

            //then
            Assert.That(log.InfoEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithVerboseOutputWritesDebugLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(true);

            //then
            Assert.That(log.DebugEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithoutVerboseOutputWritesErrorLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(false);

            //then
            Assert.That(log.ErrorEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithoutVerboseOutputWritesWarnLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(false);

            //then
            Assert.That(log.WarnEnabled, Is.True);
        }

        [Test]
        public void DefaultLoggerWithoutVerboseOutputWritesInfoLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(false);

            //then
            Assert.That(log.InfoEnabled, Is.False);
        }

        [Test]
        public void DefaultLoggerWithoutVerboseOutputWritesDebugLevelMessages()
        {
            //given
            DefaultLogger log = new DefaultLogger(false);

            //then
            Assert.That(log.DebugEnabled, Is.False);
        }
    }
}
