﻿using System;

namespace DesafioCartSys.Business.Models

{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
