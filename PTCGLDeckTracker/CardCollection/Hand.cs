﻿using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCGLDeckTracker.CardCollection
{
    internal class Hand : CardCollection
    {
        public override void OnCardAdded(Card3D cardAdded)
        {
            Melon<IronTracks>.Logger.Msg("Added Card " + cardAdded.name + " into hand.");
        }

        public override void OnCardRemoved(Card3D cardRemoved)
        {
            Melon<IronTracks>.Logger.Msg("Removed Card " + cardRemoved.name + " from hand.");
        }
    }
}
