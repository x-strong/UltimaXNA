﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterXLib.Patterns.MVC;

namespace UltimaXNA
{
    abstract internal class AUltimaModel : AModel
    {
        public UltimaClient Client { get; private set; }

        public void Initialize(UltimaClient client)
        {
            Client = client;
            OnInitialize();
        }

        public void Dispose()
        {
            OnDispose();
        }

        protected abstract void OnInitialize();
        protected abstract void OnDispose();

        protected override AController CreateController()
        {
            throw new NotImplementedException();
        }

        protected override AView CreateView()
        {
            throw new NotImplementedException();
        }
    }
}
