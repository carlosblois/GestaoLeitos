﻿using Administrativo.API.IntegrationEvents.Events;
using EventBus.Abstractions;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

using System;

using System.Threading.Tasks;

namespace Notification.HUB.IntegrationEvents.EventHandling
{

    public class AcessoEmpresaPerfilTSTASaveIEHandler :
        IIntegrationEventHandler<AcessoEmpresaPerfilTSTASaveIE>
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public AcessoEmpresaPerfilTSTASaveIEHandler(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext ?? throw new ArgumentNullException(nameof(hubContext));
        }


        public async Task Handle(AcessoEmpresaPerfilTSTASaveIE @event)
        {
            var jsonMessage = JsonConvert.SerializeObject(@event);
            await _hubContext.Clients.All
                .SendAsync("ReceiveMessage", "AcessoEmpresaPerfilTSTASaveIE", @event.Id, jsonMessage);

        }
    }
}