﻿using NorthWindEntities.Interfaces;
using NorthWindEntities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
    internal class ProductService(IUserActionWriter writer):IProductService
    {
        public void Add(string user, string productName)
        {
            UserAction Action = new UserAction(user, $"Created: {productName}");
            writer.Write(Action);
        }
    }
}
