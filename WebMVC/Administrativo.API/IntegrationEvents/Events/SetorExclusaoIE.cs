﻿using EventBus.Events;
using System;
using System.Collections.Generic;

namespace Administrativo.API.IntegrationEvents.Events
{
    // Integration Events notes: 
    // An Event is “something that has happened in the past”, therefore its name has to be   
    // An Integration Event is an event that can cause side effects to other microsrvices, Bounded-Contexts or external systems.
    public class SetorExclusaoIE : IntegrationEvent
    {
        public int EmpresaId { get; private set; }
        public int SetorId { get; private set; }


        public SetorExclusaoIE(int empresaId, int setorId)
        {
            EmpresaId = empresaId;
            SetorId = setorId;
        }

    }
}
