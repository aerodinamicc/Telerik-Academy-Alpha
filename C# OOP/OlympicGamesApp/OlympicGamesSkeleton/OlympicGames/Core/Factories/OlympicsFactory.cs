﻿using System;
using System.Collections.Generic;

using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics.Models;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        private static OlympicsFactory instance = new OlympicsFactory();

        private OlympicsFactory() { }

        public static OlympicsFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            // TODO: Implement this
            return new Boxer(firstName, lastName, country, category, wins, losses);

        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records)
        {
            // TODO: Implement this
            return new Sprinter(firstName, lastName, country, records);

           
        }
    }
}
