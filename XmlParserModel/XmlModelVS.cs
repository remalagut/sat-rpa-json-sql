using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATRpaToJson.XmlParserModel.FromVS
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = false)]
    public partial class envCFe
    {

        private byte tpAmbField;

        private string idLoteField;

        private byte cUFField;

        private envCFeCFe[] loteCFeField;

        private object nSegField;

        private ulong dhEnvioField;

        private string nserieSATField;

        private decimal versaoField;

        /// <remarks/>
        public byte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        /// <remarks/>
        public byte cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CFe", IsNullable = false)]
        public envCFeCFe[] LoteCFe
        {
            get
            {
                return this.loteCFeField;
            }
            set
            {
                this.loteCFeField = value;
            }
        }

        /// <remarks/>
        public object nSeg
        {
            get
            {
                return this.nSegField;
            }
            set
            {
                this.nSegField = value;
            }
        }

        /// <remarks/>
        public ulong dhEnvio
        {
            get
            {
                return this.dhEnvioField;
            }
            set
            {
                this.dhEnvioField = value;
            }
        }

        /// <remarks/>
        public string nserieSAT
        {
            get
            {
                return this.nserieSATField;
            }
            set
            {
                this.nserieSATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFe
    {

        private envCFeCFeInfCFe infCFeField;

        private Signature signatureField;

        /// <remarks/>
        public envCFeCFeInfCFe infCFe
        {
            get
            {
                return this.infCFeField;
            }
            set
            {
                this.infCFeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFe
    {

        private envCFeCFeInfCFeIde ideField;

        private envCFeCFeInfCFeEmit emitField;

        private envCFeCFeInfCFeDest destField;

        private envCFeCFeInfCFeDet[] detField;

        private envCFeCFeInfCFeTotal totalField;

        private envCFeCFeInfCFePgto pgtoField;

        private envCFeCFeInfCFeInfAdic infAdicField;

        private envCFeCFeInfCFeObsFisco obsFiscoField;

        private string idField;

        private decimal versaoField;

        private decimal versaoDadosEntField;

        private string versaoSBField;

        /// <remarks/>
        public envCFeCFeInfCFeIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("det")]
        public envCFeCFeInfCFeDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFePgto pgto
        {
            get
            {
                return this.pgtoField;
            }
            set
            {
                this.pgtoField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeObsFisco obsFisco
        {
            get
            {
                return this.obsFiscoField;
            }
            set
            {
                this.obsFiscoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal versaoDadosEnt
        {
            get
            {
                return this.versaoDadosEntField;
            }
            set
            {
                this.versaoDadosEntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versaoSB
        {
            get
            {
                return this.versaoSBField;
            }
            set
            {
                this.versaoSBField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeIde
    {

        private byte cUFField;

        private string cNFField;

        private byte modField;

        private string nserieSATField;

        private string nCFeField;

        private string dEmiField;

        private string hEmiField;

        private byte cDVField;

        private byte tpAmbField;

        private ulong cNPJField;

        private string signACField;

        private string assinaturaQRCODEField;

        private byte numeroCaixaField;

        /// <remarks/>
        public byte cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <remarks/>
        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        /// <remarks/>
        public byte mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        public string nserieSAT
        {
            get
            {
                return this.nserieSATField;
            }
            set
            {
                this.nserieSATField = value;
            }
        }

        /// <remarks/>
        public string nCFe
        {
            get
            {
                return this.nCFeField;
            }
            set
            {
                this.nCFeField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        /// <remarks/>
        public string hEmi
        {
            get
            {
                return this.hEmiField;
            }
            set
            {
                this.hEmiField = value;
            }
        }

        /// <remarks/>
        public byte cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        /// <remarks/>
        public byte tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string signAC
        {
            get
            {
                return this.signACField;
            }
            set
            {
                this.signACField = value;
            }
        }

        /// <remarks/>
        public string assinaturaQRCODE
        {
            get
            {
                return this.assinaturaQRCODEField;
            }
            set
            {
                this.assinaturaQRCODEField = value;
            }
        }

        /// <remarks/>
        public byte numeroCaixa
        {
            get
            {
                return this.numeroCaixaField;
            }
            set
            {
                this.numeroCaixaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeEmit
    {

        private ulong cNPJField;

        private string xNomeField;

        private envCFeCFeInfCFeEmitEnderEmit enderEmitField;

        private ulong ieField;

        private byte imField;

        private byte cRegTribField;

        private string indRatISSQNField;

        /// <remarks/>
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeEmitEnderEmit enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        /// <remarks/>
        public ulong IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        /// <remarks/>
        public byte IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        /// <remarks/>
        public byte cRegTrib
        {
            get
            {
                return this.cRegTribField;
            }
            set
            {
                this.cRegTribField = value;
            }
        }

        /// <remarks/>
        public string indRatISSQN
        {
            get
            {
                return this.indRatISSQNField;
            }
            set
            {
                this.indRatISSQNField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeEmitEnderEmit
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string xMunField;

        private string cEPField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        /// <remarks/>
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDest
    {

        private ulong cNPJField;

        private string xNomeField;

        /// <remarks/>
        public ulong CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDet
    {

        private envCFeCFeInfCFeDetProd prodField;

        private envCFeCFeInfCFeDetImposto impostoField;

        private byte nItemField;

        /// <remarks/>
        public envCFeCFeInfCFeDetProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetProd
    {

        private string cProdField;

        private ulong cEANField;

        private bool cEANFieldSpecified;

        private string xProdField;

        private string nCMField;

        private string cESTField;

        private bool cESTFieldSpecified;

        private string cFOPField;

        private string uComField;

        private decimal qComField;

        private decimal vUnComField;

        private decimal vProdField;

        private string indRegraField;

        private decimal vItemField;

        private envCFeCFeInfCFeDetProdObsFiscoDet obsFiscoDetField;

        /// <remarks/>
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        /// <remarks/>
        public ulong cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cEANSpecified
        {
            get
            {
                return this.cEANFieldSpecified;
            }
            set
            {
                this.cEANFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        /// <remarks/>
        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        /// <remarks/>
        public string CEST
        {
            get
            {
                return this.cESTField;
            }
            set
            {
                this.cESTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CESTSpecified
        {
            get
            {
                return this.cESTFieldSpecified;
            }
            set
            {
                this.cESTFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <remarks/>
        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        /// <remarks/>
        public decimal qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        /// <remarks/>
        public decimal vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        /// <remarks/>
        public decimal vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public string indRegra
        {
            get
            {
                return this.indRegraField;
            }
            set
            {
                this.indRegraField = value;
            }
        }

        /// <remarks/>
        public decimal vItem
        {
            get
            {
                return this.vItemField;
            }
            set
            {
                this.vItemField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetProdObsFiscoDet obsFiscoDet
        {
            get
            {
                return this.obsFiscoDetField;
            }
            set
            {
                this.obsFiscoDetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetProdObsFiscoDet
    {

        private string xTextoDetField;

        private string xCampoDetField;

        /// <remarks/>
        public string xTextoDet
        {
            get
            {
                return this.xTextoDetField;
            }
            set
            {
                this.xTextoDetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampoDet
        {
            get
            {
                return this.xCampoDetField;
            }
            set
            {
                this.xCampoDetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImposto
    {

        private decimal vItem12741Field;

        private envCFeCFeInfCFeDetImpostoICMS iCMSField;

        private envCFeCFeInfCFeDetImpostoPIS pISField;

        private envCFeCFeInfCFeDetImpostoCOFINS cOFINSField;

        /// <remarks/>
        public decimal vItem12741
        {
            get
            {
                return this.vItem12741Field;
            }
            set
            {
                this.vItem12741Field = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoICMS ICMS
        {
            get
            {
                return this.iCMSField;
            }
            set
            {
                this.iCMSField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoICMS
    {

        private envCFeCFeInfCFeDetImpostoICMSICMS00 iCMS00Field;

        private envCFeCFeInfCFeDetImpostoICMSICMS40 iCMS40Field;

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoICMSICMS00 ICMS00
        {
            get
            {
                return this.iCMS00Field;
            }
            set
            {
                this.iCMS00Field = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoICMSICMS40 ICMS40
        {
            get
            {
                return this.iCMS40Field;
            }
            set
            {
                this.iCMS40Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoICMSICMS00
    {

        private byte origField;

        private byte cSTField;

        private decimal pICMSField;

        private decimal vICMSField;

        /// <remarks/>
        public byte Orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public decimal pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <remarks/>
        public decimal vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoICMSICMS40
    {

        private byte origField;

        private byte cSTField;

        /// <remarks/>
        public byte Orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoPIS
    {

        private envCFeCFeInfCFeDetImpostoPISPISAliq pISAliqField;

        private envCFeCFeInfCFeDetImpostoPISPISNT pISNTField;

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoPISPISAliq PISAliq
        {
            get
            {
                return this.pISAliqField;
            }
            set
            {
                this.pISAliqField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoPISPISNT PISNT
        {
            get
            {
                return this.pISNTField;
            }
            set
            {
                this.pISNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoPISPISAliq
    {

        private byte cSTField;

        private decimal vBCField;

        private decimal pPISField;

        private decimal vPISField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        /// <remarks/>
        public decimal vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoPISPISNT
    {

        private byte cSTField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoCOFINS
    {

        private envCFeCFeInfCFeDetImpostoCOFINSCOFINSAliq cOFINSAliqField;

        private envCFeCFeInfCFeDetImpostoCOFINSCOFINSNT cOFINSNTField;

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoCOFINSCOFINSAliq COFINSAliq
        {
            get
            {
                return this.cOFINSAliqField;
            }
            set
            {
                this.cOFINSAliqField = value;
            }
        }

        /// <remarks/>
        public envCFeCFeInfCFeDetImpostoCOFINSCOFINSNT COFINSNT
        {
            get
            {
                return this.cOFINSNTField;
            }
            set
            {
                this.cOFINSNTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoCOFINSCOFINSAliq
    {

        private byte cSTField;

        private decimal vBCField;

        private decimal pCOFINSField;

        private decimal vCOFINSField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <remarks/>
        public decimal vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <remarks/>
        public decimal pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        /// <remarks/>
        public decimal vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeDetImpostoCOFINSCOFINSNT
    {

        private byte cSTField;

        /// <remarks/>
        public byte CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeTotal
    {

        private envCFeCFeInfCFeTotalICMSTot iCMSTotField;

        private decimal vCFeField;

        /// <remarks/>
        public envCFeCFeInfCFeTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        /// <remarks/>
        public decimal vCFe
        {
            get
            {
                return this.vCFeField;
            }
            set
            {
                this.vCFeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeTotalICMSTot
    {

        private decimal vICMSField;

        private decimal vProdField;

        private decimal vDescField;

        private decimal vPISField;

        private decimal vCOFINSField;

        private decimal vPISSTField;

        private decimal vCOFINSSTField;

        private decimal vOutroField;

        /// <remarks/>
        public decimal vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <remarks/>
        public decimal vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <remarks/>
        public decimal vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <remarks/>
        public decimal vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        /// <remarks/>
        public decimal vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <remarks/>
        public decimal vPISST
        {
            get
            {
                return this.vPISSTField;
            }
            set
            {
                this.vPISSTField = value;
            }
        }

        /// <remarks/>
        public decimal vCOFINSST
        {
            get
            {
                return this.vCOFINSSTField;
            }
            set
            {
                this.vCOFINSSTField = value;
            }
        }

        /// <remarks/>
        public decimal vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFePgto
    {

        private envCFeCFeInfCFePgtoMP mpField;

        private decimal vTrocoField;

        /// <remarks/>
        public envCFeCFeInfCFePgtoMP MP
        {
            get
            {
                return this.mpField;
            }
            set
            {
                this.mpField = value;
            }
        }

        /// <remarks/>
        public decimal vTroco
        {
            get
            {
                return this.vTrocoField;
            }
            set
            {
                this.vTrocoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFePgtoMP
    {

        private byte cMPField;

        private decimal vMPField;

        private string cAdmCField;

        private bool cAdmCFieldSpecified;

        /// <remarks/>
        public byte cMP
        {
            get
            {
                return this.cMPField;
            }
            set
            {
                this.cMPField = value;
            }
        }

        /// <remarks/>
        public decimal vMP
        {
            get
            {
                return this.vMPField;
            }
            set
            {
                this.vMPField = value;
            }
        }

        /// <remarks/>
        public string cAdmC
        {
            get
            {
                return this.cAdmCField;
            }
            set
            {
                this.cAdmCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cAdmCSpecified
        {
            get
            {
                return this.cAdmCFieldSpecified;
            }
            set
            {
                this.cAdmCFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeInfAdic
    {

        private string infCplField;

        /// <remarks/>
        public string infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                this.infCplField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public partial class envCFeCFeInfCFeObsFisco
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private string signatureValueField;

        private SignatureKeyInfo keyInfoField;

        /// <remarks/>
        public SignatureSignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public SignatureKeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference referenceField;

        /// <remarks/>
        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReference Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceTransform[] transformsField;

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public SignatureSignedInfoReferenceTransform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceTransform
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoX509Data x509DataField;

        /// <remarks/>
        public SignatureKeyInfoX509Data X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509CertificateField;

        /// <remarks/>
        public string X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }


}
