using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControleDeValidades
{
    public class NFeData
    {
        public int ID { get; set; }
        public string Referência { get; set; }
        public string Descrição { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }

        public List<NFeData> ReturnDados(string path)
        {
            // Ler o XML da NFe
            XDocument doc = XDocument.Load(path);

            // Namespace do XML
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            // Dados do fornecedor (emissor)
            var emitente = doc.Descendants(ns + "emit").FirstOrDefault();
            string cnpj = emitente.Element(ns + "CNPJ").Value;
            string nome = emitente.Element(ns + "xNome").Value;
            string endereco = emitente.Element(ns + "enderEmit").Element(ns + "xLgr").Value;
            string cidade = emitente.Element(ns + "enderEmit").Element(ns + "xMun").Value;
            string uf = emitente.Element(ns + "enderEmit").Element(ns + "UF").Value;

            // Lista para armazenar os dados dos produtos
            List<NFeData> products = new List<NFeData>();

            // Loop através das tags <det> no XML
            foreach (XElement det in doc.Descendants(ns + "det"))
            {
                // Extrair os dados do produto
                NFeData product = new NFeData
                {
                    ID = int.Parse(det.Element(ns + "nItem").Value),
                    Referência = det.Element(ns + "prod").Element(ns + "cProd").Value,
                    Descrição = det.Element(ns + "prod").Element(ns + "xProd").Value,
                    Quantidade = int.Parse(det.Element(ns + "prod").Element(ns + "qCom").Value.Split('.')[0]),
                    Fornecedor = nome
                    
                };
                // Adicionar o produto à lista
                products.Add(product);
            }

            // Preencher o DataGridView com os dados dos produtos
            return products;
        }

    }

    
}
     
