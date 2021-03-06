﻿using EventBus.Events;
using Usuario.API.Model;
using System;
using System.Collections.Generic;

namespace Usuario.API.IntegrationEvents.Events
{
    // Integration Events notes: 
    // An Event is “something that has happened in the past”, therefore its name has to be   
    // An Integration Event is an event that can cause side effects to other microsrvices, Bounded-Contexts or external systems.
    public class UsuarioExclusaoIE : IntegrationEvent
    {
        public int UsuarioId { get; private set; }

        public UsuarioExclusaoIE(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

    }
    public class UsuarioExclusaoGrupoIE : IntegrationEvent
    {

        public IEnumerable<UsuarioItem> UsuarioItems { get; }

        public UsuarioExclusaoGrupoIE(IEnumerable<UsuarioItem> usuarioItems)
        {
            UsuarioItems = usuarioItems;
        }
    }
}
