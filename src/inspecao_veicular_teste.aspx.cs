using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using creaweb.webservices.DTOs.ART.InspecaoVeicular;

namespace creaweb.webservices.ws.art
{
	public partial class inspecao_veicular_teste : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void cmdTestarWS_OnClick(object sender, EventArgs e)
		{
			var ws = new InspecaoVeicular();
			var inspecDTO = new InspecaoVeicularDTO
			{
				CPFProfissional = "00443293937",
				CNPJEmpresa = "00000000000000",
				EnderecoServico = new EnderecoDTO
				{
					Cep = 80035250,
					Bairro = "Bairro serviço",
					Complemento = "complemento serv",
					Logradouro = "logradouro endereço serv",
					Numero = "num123"
				},
				Servicos = new List<ServicoDTO>()
				{
					new ServicoDTO
					{
						ID = 1,
						CIPP = "CIP1",
						CIV = 1,
						CSV = "CSV",
						CpfCnpj = "22222222222",
						EnderecoContratante = new EnderecoDTO
						{
							Cep = 81070170,
							Bairro = "Bairro contrat",
							Complemento = "complemento contrat",
							Logradouro = "logradouro endereço contrat",
							Numero = "num456"
						},
						NomeRazaoSocial = "Nome razao social",
						Placa = "ALD8333",
						ValorServico = (decimal) 987.65
					},
					new ServicoDTO
					{
						ID = 2,
						CIPP = "CIP2",
						CIV = 2,
						CSV = "CSV3",
						CpfCnpj = "33333333333",
						EnderecoContratante = new EnderecoDTO
						{
							Cep = 81070180,
							Bairro = "Bairro contrat",
							Complemento = "complemento contrat",
							Logradouro = "logradouro endereço contrat",
							Numero = "num456"
						},
						NomeRazaoSocial = "Nome razao social2",
						Placa = "ALD8334",
						ValorServico = (decimal) 987.66
					},
					new ServicoDTO
					{
						ID = 3,
						CIPP = "CIP3",
						CIV = 3,
						CSV = "CSV4",
						CpfCnpj = "44444444444",
						EnderecoContratante = new EnderecoDTO
						{
							Cep = 81070190,
							Bairro = "Bairro contrat",
							Complemento = "complemento contrat",
							Logradouro = "logradouro endereço contrat",
							Numero = "num456"
						},
						NomeRazaoSocial = "Nome razao social3",
						Placa = "ALD8335",
						ValorServico = (decimal) 987.67
					}
				}
			};

			var erros = ws.EnviarInspecaoVeicular(inspecDTO);

			if (erros.Any())
			{
				bltErros.DataSource = erros;
				bltErros.DataBind();
			}
			else
			{
				cmdTestarWS.Text = "Inspeções enviadas com sucesso";
			}
		}
	}
}
