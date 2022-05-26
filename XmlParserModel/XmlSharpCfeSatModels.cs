using System.Collections.Generic;
using System.Xml.Serialization;

namespace SATRpaToJson.XmlParserModel
{
    /* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */


    [XmlRoot(ElementName = "ide", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Ide
        {
            [XmlElement(ElementName = "cUF", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CUF { get; set; }
            [XmlElement(ElementName = "cNF", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CNF { get; set; }
            [XmlElement(ElementName = "mod", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string Mod { get; set; }
            [XmlElement(ElementName = "nserieSAT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NserieSAT { get; set; }
            [XmlElement(ElementName = "nCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NCFe { get; set; }
            [XmlElement(ElementName = "dEmi", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string DEmi { get; set; }
            [XmlElement(ElementName = "hEmi", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string HEmi { get; set; }
            [XmlElement(ElementName = "cDV", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CDV { get; set; }
            [XmlElement(ElementName = "tpAmb", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string TpAmb { get; set; }
            [XmlElement(ElementName = "CNPJ", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CNPJ { get; set; }
            [XmlElement(ElementName = "signAC", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string SignAC { get; set; }
            [XmlElement(ElementName = "assinaturaQRCODE", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string AssinaturaQRCODE { get; set; }
            [XmlElement(ElementName = "numeroCaixa", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NumeroCaixa { get; set; }
        }

        [XmlRoot(ElementName = "enderEmit", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class EnderEmit
        {
            [XmlElement(ElementName = "xLgr", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XLgr { get; set; }
            [XmlElement(ElementName = "nro", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string Nro { get; set; }
            [XmlElement(ElementName = "xCpl", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XCpl { get; set; }
            [XmlElement(ElementName = "xBairro", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XBairro { get; set; }
            [XmlElement(ElementName = "xMun", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XMun { get; set; }
            [XmlElement(ElementName = "CEP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CEP { get; set; }
        }

        [XmlRoot(ElementName = "emit", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Emit
        {
            [XmlElement(ElementName = "CNPJ", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CNPJ { get; set; }
            [XmlElement(ElementName = "xNome", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XNome { get; set; }
            [XmlElement(ElementName = "enderEmit", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public EnderEmit EnderEmit { get; set; }
            [XmlElement(ElementName = "IE", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string IE { get; set; }
            [XmlElement(ElementName = "IM", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string IM { get; set; }
            [XmlElement(ElementName = "cRegTrib", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CRegTrib { get; set; }
            [XmlElement(ElementName = "indRatISSQN", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string IndRatISSQN { get; set; }
        }

        [XmlRoot(ElementName = "obsFiscoDet", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ObsFiscoDet
        {
            [XmlElement(ElementName = "xTextoDet", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XTextoDet { get; set; }
            [XmlAttribute(AttributeName = "xCampoDet")]
            public string XCampoDet { get; set; }
        }

        [XmlRoot(ElementName = "prod", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Prod
        {
            [XmlElement(ElementName = "cProd", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CProd { get; set; }
            [XmlElement(ElementName = "xProd", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XProd { get; set; }
            [XmlElement(ElementName = "NCM", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NCM { get; set; }
            [XmlElement(ElementName = "CEST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CEST { get; set; }
            [XmlElement(ElementName = "CFOP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CFOP { get; set; }
            [XmlElement(ElementName = "uCom", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string UCom { get; set; }
            [XmlElement(ElementName = "qCom", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string QCom { get; set; }
            [XmlElement(ElementName = "vUnCom", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VUnCom { get; set; }
            [XmlElement(ElementName = "vProd", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VProd { get; set; }
            [XmlElement(ElementName = "indRegra", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string IndRegra { get; set; }
            [XmlElement(ElementName = "vItem", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VItem { get; set; }
            [XmlElement(ElementName = "obsFiscoDet", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ObsFiscoDet ObsFiscoDet { get; set; }
        }

        [XmlRoot(ElementName = "ICMS40", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ICMS40
        {
            [XmlElement(ElementName = "Orig", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string Orig { get; set; }
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
        }

        [XmlRoot(ElementName = "ICMS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ICMS
        {
            [XmlElement(ElementName = "ICMS40", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ICMS40 ICMS40 { get; set; }
            [XmlElement(ElementName = "ICMS00", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ICMS00 ICMS00 { get; set; }
        }

        [XmlRoot(ElementName = "PISNT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class PISNT
        {
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
        }

        [XmlRoot(ElementName = "PIS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class PIS
        {
            [XmlElement(ElementName = "PISNT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public PISNT PISNT { get; set; }
            [XmlElement(ElementName = "PISAliq", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public PISAliq PISAliq { get; set; }
        }

        [XmlRoot(ElementName = "COFINSNT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class COFINSNT
        {
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
        }

        [XmlRoot(ElementName = "COFINS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class COFINS
        {
            [XmlElement(ElementName = "COFINSNT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public COFINSNT COFINSNT { get; set; }
            [XmlElement(ElementName = "COFINSAliq", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public COFINSAliq COFINSAliq { get; set; }
        }

        [XmlRoot(ElementName = "imposto", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Imposto
        {
            [XmlElement(ElementName = "vItem12741", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VItem12741 { get; set; }
            [XmlElement(ElementName = "ICMS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ICMS ICMS { get; set; }
            [XmlElement(ElementName = "PIS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public PIS PIS { get; set; }
            [XmlElement(ElementName = "COFINS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public COFINS COFINS { get; set; }
        }

        [XmlRoot(ElementName = "det", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Det
        {
            [XmlElement(ElementName = "prod", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Prod Prod { get; set; }
            [XmlElement(ElementName = "imposto", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Imposto Imposto { get; set; }
            [XmlAttribute(AttributeName = "nItem")]
            public string NItem { get; set; }
        }

        [XmlRoot(ElementName = "ICMSTot", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ICMSTot
        {
            [XmlElement(ElementName = "vICMS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VICMS { get; set; }
            [XmlElement(ElementName = "vProd", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VProd { get; set; }
            [XmlElement(ElementName = "vDesc", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VDesc { get; set; }
            [XmlElement(ElementName = "vPIS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VPIS { get; set; }
            [XmlElement(ElementName = "vCOFINS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VCOFINS { get; set; }
            [XmlElement(ElementName = "vPISST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VPISST { get; set; }
            [XmlElement(ElementName = "vCOFINSST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VCOFINSST { get; set; }
            [XmlElement(ElementName = "vOutro", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VOutro { get; set; }
        }

        [XmlRoot(ElementName = "total", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Total
        {
            [XmlElement(ElementName = "ICMSTot", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ICMSTot ICMSTot { get; set; }
            [XmlElement(ElementName = "vCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VCFe { get; set; }
        }

        [XmlRoot(ElementName = "MP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class MP
        {
            [XmlElement(ElementName = "cMP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CMP { get; set; }
            [XmlElement(ElementName = "vMP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VMP { get; set; }
            [XmlElement(ElementName = "cAdmC", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CAdmC { get; set; }
        }

        [XmlRoot(ElementName = "pgto", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class Pgto
        {
            [XmlElement(ElementName = "MP", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public List<MP> MP { get; set; }
            [XmlElement(ElementName = "vTroco", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VTroco { get; set; }
        }

        [XmlRoot(ElementName = "infAdic", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class InfAdic
        {
            [XmlElement(ElementName = "infCpl", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string InfCpl { get; set; }
        }

        [XmlRoot(ElementName = "obsFisco", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ObsFisco
        {
            [XmlElement(ElementName = "xTexto", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string XTexto { get; set; }
            [XmlAttribute(AttributeName = "xCampo")]
            public string XCampo { get; set; }
        }

        [XmlRoot(ElementName = "infCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class InfCFe
        {
            [XmlElement(ElementName = "ide", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Ide Ide { get; set; }
            [XmlElement(ElementName = "emit", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Emit Emit { get; set; }
            [XmlElement(ElementName = "dest", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string Dest { get; set; }
            [XmlElement(ElementName = "det", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public List<Det> Det { get; set; }
            [XmlElement(ElementName = "total", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Total Total { get; set; }
            [XmlElement(ElementName = "pgto", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public Pgto Pgto { get; set; }
            [XmlElement(ElementName = "infAdic", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public InfAdic InfAdic { get; set; }
            [XmlElement(ElementName = "obsFisco", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public ObsFisco ObsFisco { get; set; }
            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }
            [XmlAttribute(AttributeName = "versao")]
            public string Versao { get; set; }
            [XmlAttribute(AttributeName = "versaoDadosEnt")]
            public string VersaoDadosEnt { get; set; }
            [XmlAttribute(AttributeName = "versaoSB")]
            public string VersaoSB { get; set; }
        }

        [XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class CanonicalizationMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class SignatureMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Transform
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Transforms
        {
            [XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public List<Transform> Transform { get; set; }
        }

        [XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class DigestMethod
        {
            [XmlAttribute(AttributeName = "Algorithm")]
            public string Algorithm { get; set; }
        }

        [XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Reference
        {
            [XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Transforms Transforms { get; set; }
            [XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public DigestMethod DigestMethod { get; set; }
            [XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string DigestValue { get; set; }
            [XmlAttribute(AttributeName = "URI")]
            public string URI { get; set; }
        }

        [XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class SignedInfo
        {
            [XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }
            [XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public SignatureMethod SignatureMethod { get; set; }
            [XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Reference Reference { get; set; }
        }

        [XmlRoot(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class X509Data
        {
            [XmlElement(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string X509Certificate { get; set; }
        }

        [XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class KeyInfo
        {
            [XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public X509Data X509Data { get; set; }
        }

        [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public class Signature
        {
            [XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public SignedInfo SignedInfo { get; set; }
            [XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public string SignatureValue { get; set; }
            [XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public KeyInfo KeyInfo { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
        }

        [XmlRoot(ElementName = "CFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class CFe
        {
            [XmlElement(ElementName = "infCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public InfCFe InfCFe { get; set; }
            [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
            public Signature Signature { get; set; }
        }

        [XmlRoot(ElementName = "PISAliq", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class PISAliq
        {
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
            [XmlElement(ElementName = "vBC", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VBC { get; set; }
            [XmlElement(ElementName = "pPIS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string PPIS { get; set; }
            [XmlElement(ElementName = "vPIS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VPIS { get; set; }
        }

        [XmlRoot(ElementName = "COFINSAliq", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class COFINSAliq
        {
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
            [XmlElement(ElementName = "vBC", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VBC { get; set; }
            [XmlElement(ElementName = "pCOFINS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string PCOFINS { get; set; }
            [XmlElement(ElementName = "vCOFINS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VCOFINS { get; set; }
        }

        [XmlRoot(ElementName = "ICMS00", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class ICMS00
        {
            [XmlElement(ElementName = "Orig", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string Orig { get; set; }
            [XmlElement(ElementName = "CST", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CST { get; set; }
            [XmlElement(ElementName = "pICMS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string PICMS { get; set; }
            [XmlElement(ElementName = "vICMS", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string VICMS { get; set; }
        }

        [XmlRoot(ElementName = "LoteCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class LoteCFe
        {
            [XmlElement(ElementName = "CFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public List<CFe> CFe { get; set; }
        }

        [XmlRoot(ElementName = "envCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
        public class EnvCFe
        {
            [XmlElement(ElementName = "tpAmb", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string TpAmb { get; set; }
            [XmlElement(ElementName = "idLote", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string IdLote { get; set; }
            [XmlElement(ElementName = "cUF", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string CUF { get; set; }
            [XmlElement(ElementName = "LoteCFe", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public LoteCFe LoteCFe { get; set; }
            [XmlElement(ElementName = "nSeg", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NSeg { get; set; }
            [XmlElement(ElementName = "dhEnvio", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string DhEnvio { get; set; }
            [XmlElement(ElementName = "nserieSAT", Namespace = "http://www.fazenda.sp.gov.br/sat", IsNullable = true)]
            public string NserieSAT { get; set; }
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
            [XmlAttribute(AttributeName = "versao")]
            public string Versao { get; set; }
    }

}
