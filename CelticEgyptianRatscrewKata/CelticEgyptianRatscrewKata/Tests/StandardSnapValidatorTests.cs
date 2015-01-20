﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class StandardSnapValidatorTests
    {
        [Test]
        public void EmptyStackIsNotSnap()
        {
            var stack = CreateStack();
            var isSnap = IsSnap(stack);
            Assert.That(isSnap, Is.False);
        }

        [Test]
        public void SingleCardIsNotSnap()
        {
            var stack = CreateStack(new Card(Suit.Clubs, Rank.Ace));
            var isSnap = IsSnap(stack);
            Assert.That(isSnap, Is.False);
        }

        [Test]
        public void TwoEqualCardsIsSnap()
        {
            var card = new Card(Suit.Clubs, Rank.Ace);
            var stack = CreateStack(card, card);
            var isSnap = IsSnap(stack);
            Assert.That(isSnap, Is.True);
        }

        private static Stack CreateStack(params Card[] cards)
        {
            return new Stack(cards);
        }

        private bool IsSnap(Stack stack)
        {
            var lastRank = (Rank) -1;
            foreach (var card in stack)
            {
                if (lastRank == card.)
            }
        }
    }
}
