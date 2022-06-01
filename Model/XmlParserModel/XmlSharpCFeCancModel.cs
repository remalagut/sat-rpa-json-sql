using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SATRpaToJson.XmlParserModel.XmlSharpCFeCancModel
{
    [XmlRoot(ElementName = "ide", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class Ide
    {
        [XmlElement(ElementName = "cUF", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CUF { get; set; }
        [XmlElement(ElementName = "cNF", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CNF { get; set; }
        [XmlElement(ElementName = "mod", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string Mod { get; set; }
        [XmlElement(ElementName = "nserieSAT", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string NserieSAT { get; set; }
        [XmlElement(ElementName = "nCFe", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string NCFe { get; set; }
        [XmlElement(ElementName = "dEmi", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string DEmi { get; set; }
        [XmlElement(ElementName = "hEmi", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string HEmi { get; set; }
        [XmlElement(ElementName = "cDV", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CDV { get; set; }
        [XmlElement(ElementName = "CNPJ", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CNPJ { get; set; }
        [XmlElement(ElementName = "signAC", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string SignAC { get; set; }
        [XmlElement(ElementName = "assinaturaQRCODE", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string AssinaturaQRCODE { get; set; }
        [XmlElement(ElementName = "numeroCaixa", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string NumeroCaixa { get; set; }
    }

    [XmlRoot(ElementName = "enderEmit", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class EnderEmit
    {
        [XmlElement(ElementName = "xLgr", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XLgr { get; set; }
        [XmlElement(ElementName = "nro", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string Nro { get; set; }
        [XmlElement(ElementName = "xCpl", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XCpl { get; set; }
        [XmlElement(ElementName = "xBairro", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XBairro { get; set; }
        [XmlElement(ElementName = "xMun", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XMun { get; set; }
        [XmlElement(ElementName = "CEP", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CEP { get; set; }
    }

    [XmlRoot(ElementName = "emit", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class Emit
    {
        [XmlElement(ElementName = "CNPJ", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CNPJ { get; set; }
        [XmlElement(ElementName = "xNome", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XNome { get; set; }
        [XmlElement(ElementName = "enderEmit", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public EnderEmit EnderEmit { get; set; }
        [XmlElement(ElementName = "IE", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string IE { get; set; }
        [XmlElement(ElementName = "IM", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string IM { get; set; }
    }

    [XmlRoot(ElementName = "total", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class Total
    {
        [XmlElement(ElementName = "vCFe", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string VCFe { get; set; }
    }

    [XmlRoot(ElementName = "obsFisco", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class ObsFisco
    {
        [XmlElement(ElementName = "xTexto", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string XTexto { get; set; }
        [XmlAttribute(AttributeName = "xCampo")]
        public string XCampo { get; set; }
    }

    [XmlRoot(ElementName = "infAdic", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class InfAdic
    {
        [XmlElement(ElementName = "obsFisco", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public ObsFisco ObsFisco { get; set; }
    }

    [XmlRoot(ElementName = "infCFe", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class InfCFe
    {
        [XmlElement(ElementName = "dEmi", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string DEmi { get; set; }
        [XmlElement(ElementName = "hEmi", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string HEmi { get; set; }
        [XmlElement(ElementName = "ide", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public Ide Ide { get; set; }
        [XmlElement(ElementName = "emit", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public Emit Emit { get; set; }
        [XmlElement(ElementName = "dest", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string Dest { get; set; }
        [XmlElement(ElementName = "total", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public Total Total { get; set; }
        [XmlElement(ElementName = "infAdic", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public InfAdic InfAdic { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "chCanc")]
        public string ChCanc { get; set; }
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }
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

    [XmlRoot(ElementName = "CFeCanc", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class CFeCanc
    {
        [XmlElement(ElementName = "infCFe", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public InfCFe InfCFe { get; set; }
        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "LoteCFeCanc", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class LoteCFeCanc
    {
        [XmlElement(ElementName = "CFeCanc", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public List<CFeCanc> CFeCanc { get; set; }
    }

    [XmlRoot(ElementName = "cancCFe", Namespace = "http://www.fazenda.sp.gov.br/sat")]
    public class CancCFe
    {
        [XmlElement(ElementName = "tpAmb", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string TpAmb { get; set; }
        [XmlElement(ElementName = "idLote", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string IdLote { get; set; }
        [XmlElement(ElementName = "LoteCFeCanc", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public LoteCFeCanc LoteCFeCanc { get; set; }
        [XmlElement(ElementName = "cUF", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string CUF { get; set; }
        [XmlElement(ElementName = "nSeg", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string NSeg { get; set; }
        [XmlElement(ElementName = "dhEnvio", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string DhEnvio { get; set; }
        [XmlElement(ElementName = "nserieSAT", Namespace = "http://www.fazenda.sp.gov.br/sat")]
        public string NserieSAT { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "versao")]
        public string Versao { get; set; }
    }

}
