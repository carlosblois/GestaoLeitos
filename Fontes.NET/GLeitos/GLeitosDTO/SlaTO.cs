﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GLeitos.GLeitosTO
{
    public class SlaTO
    {
        public string id_SLA { get; set; }
        [Required(ErrorMessage = "O tipo de situação é obrigatório.")]
        public string id_TipoSituacaoAcomodacao { get; set; }
        [Required(ErrorMessage = "O tipo de atividade é obrigatório.")]
        public string id_TipoAtividadeAcomodacao { get; set; }
        [Required(ErrorMessage = "O tipo de ação é obrigatório.")]
        public string id_TipoAcaoAcomodacao { get; set; }
        [Required(ErrorMessage = "O tipo de acomodação é obrigatório.")]
        public string id_TipoAcomodacao { get; set; }
        [Required(ErrorMessage = "O tempo do SLA é obrigatório.")]
        public string tempo_Minutos { get; set; }
        [Required(ErrorMessage = "A versão do SLA é obrigatória.")]
        public string versao_SLA { get; set; }
       
        public string id_Empresa { get; set; }

        public string cod_enabled { get; set; }

        public SlaTO()
        {
            this.id_SLA = "";
            this.id_Empresa = "";
            this.id_TipoSituacaoAcomodacao = "";
            this.id_TipoAtividadeAcomodacao = "";
            this.id_TipoAcaoAcomodacao = "";
            this.versao_SLA = "";
            this.tempo_Minutos = "";
            this.id_TipoAcomodacao = "";
            this.cod_enabled = "S";
        }
    }
}
