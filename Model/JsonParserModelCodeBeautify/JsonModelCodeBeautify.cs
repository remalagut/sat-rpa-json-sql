using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SATRpaToJson
{
    // <auto-generated />
    //
    // To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
    //
    //    using CodeBeautify;
    //
    //    var rootObjectCfeJson = RootObjectCfeJson.FromJson(jsonString);
      public partial class RootObjectCfeJson
        {
            [JsonProperty("envCFe")]
            public EnvCFe EnvCFe { get; set; }
        }

        public partial class EnvCFe
        {
            [JsonProperty("tpAmb")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long TpAmb { get; set; }

            [JsonProperty("idLote")]
            public string IdLote { get; set; }

            [JsonProperty("cUF")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CUf { get; set; }

            [JsonProperty("LoteCFe")]
            public LoteCFe LoteCFe { get; set; }

            [JsonProperty("nSeg")]
            public string NSeg { get; set; }

            [JsonProperty("dhEnvio")]
            public string DhEnvio { get; set; }

            [JsonProperty("nserieSAT")]
            public string NserieSat { get; set; }

            [JsonProperty("_xmlns")]
            public Uri Xmlns { get; set; }

            [JsonProperty("_versao")]
            public string Versao { get; set; }
        }

        public partial class LoteCFe
        {
            [JsonProperty("CFe")]
            public CFe[] CFe { get; set; }
        }

        public partial class CFe
        {
            [JsonProperty("infCFe")]
            public InfCFe InfCFe { get; set; }

            [JsonProperty("Signature")]
            public Signature Signature { get; set; }
        }

        public partial class InfCFe
        {
            [JsonProperty("ide")]
            public Ide Ide { get; set; }

            [JsonProperty("emit")]
            public Emit Emit { get; set; }

            [JsonProperty("dest")]
            public string Dest { get; set; }

            [JsonProperty("det")]
            public DetUnion Det { get; set; }

            [JsonProperty("total")]
            public Total Total { get; set; }

            [JsonProperty("pgto")]
            public Pgto Pgto { get; set; }

            [JsonProperty("infAdic")]
            public InfAdic InfAdic { get; set; }

            [JsonProperty("_Id")]
            public string Id { get; set; }

            [JsonProperty("_versao")]
            public string Versao { get; set; }

            [JsonProperty("_versaoDadosEnt")]
            public string VersaoDadosEnt { get; set; }

            [JsonProperty("_versaoSB")]
            public string VersaoSb { get; set; }
        }

        public partial class DetElement
        {
            [JsonProperty("prod")]
            public Prod Prod { get; set; }

            [JsonProperty("imposto")]
            public Imposto Imposto { get; set; }

            [JsonProperty("_nItem")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long NItem { get; set; }
        }

        public partial class Imposto
        {
            [JsonProperty("vItem12741")]
            public string VItem12741 { get; set; }

            [JsonProperty("ICMS")]
            public Icms Icms { get; set; }

            [JsonProperty("PIS")]
            public Pis Pis { get; set; }

            [JsonProperty("COFINS")]
            public Cofins Cofins { get; set; }
        }

        public partial class Cofins
        {
            [JsonProperty("COFINSNT", NullValueHandling = NullValueHandling.Ignore)]
            public Snt Cofinsnt { get; set; }

            [JsonProperty("COFINSAliq", NullValueHandling = NullValueHandling.Ignore)]
            public CofinsAliq CofinsAliq { get; set; }
        }

        public partial class CofinsAliq
        {
            [JsonProperty("CST")]
            public string Cst { get; set; }

            [JsonProperty("vBC")]
            public string VBc { get; set; }

            [JsonProperty("pCOFINS")]
            public string PCofins { get; set; }

            [JsonProperty("vCOFINS")]
            public string VCofins { get; set; }
        }

        public partial class Snt
        {
            [JsonProperty("CST")]
            public string Cst { get; set; }
        }

        public partial class Icms
        {
            [JsonProperty("ICMS40", NullValueHandling = NullValueHandling.Ignore)]
            public Icms40 Icms40 { get; set; }

            [JsonProperty("ICMS00", NullValueHandling = NullValueHandling.Ignore)]
            public Icms00 Icms00 { get; set; }
        }

        public partial class Icms00
        {
            [JsonProperty("Orig")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Orig { get; set; }

            [JsonProperty("CST")]
            public string Cst { get; set; }

            [JsonProperty("pICMS")]
            public string PIcms { get; set; }

            [JsonProperty("vICMS")]
            public string VIcms { get; set; }
        }

        public partial class Icms40
        {
            [JsonProperty("Orig")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Orig { get; set; }

            [JsonProperty("CST")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Cst { get; set; }
        }

        public partial class Pis
        {
            [JsonProperty("PISNT", NullValueHandling = NullValueHandling.Ignore)]
            public Snt Pisnt { get; set; }

            [JsonProperty("PISAliq", NullValueHandling = NullValueHandling.Ignore)]
            public PisAliq PisAliq { get; set; }
        }

        public partial class PisAliq
        {
            [JsonProperty("CST")]
            public string Cst { get; set; }

            [JsonProperty("vBC")]
            public string VBc { get; set; }

            [JsonProperty("pPIS")]
            public string PPis { get; set; }

            [JsonProperty("vPIS")]
            public string VPis { get; set; }
        }

        public partial class Prod
        {
            [JsonProperty("cProd")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CProd { get; set; }

            [JsonProperty("cEAN", NullValueHandling = NullValueHandling.Ignore)]
            public string CEan { get; set; }

            [JsonProperty("xProd")]
            public string XProd { get; set; }

            [JsonProperty("NCM")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Ncm { get; set; }

            [JsonProperty("CFOP")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Cfop { get; set; }

            [JsonProperty("uCom")]
            public UCom UCom { get; set; }

            [JsonProperty("qCom")]
            public string QCom { get; set; }

            [JsonProperty("vUnCom")]
            public string VUnCom { get; set; }

            [JsonProperty("vProd")]
            public string VProd { get; set; }

            [JsonProperty("indRegra")]
            public IndRegra IndRegra { get; set; }

            [JsonProperty("vItem")]
            public string VItem { get; set; }

            [JsonProperty("obsFiscoDet", NullValueHandling = NullValueHandling.Ignore)]
            public ObsFiscoDet ObsFiscoDet { get; set; }
        }

        public partial class ObsFiscoDet
        {
            [JsonProperty("xTextoDet")]
            public string XTextoDet { get; set; }

            [JsonProperty("_xCampoDet")]
            public XCampoDet XCampoDet { get; set; }
        }

        public partial class Emit
        {
            [JsonProperty("CNPJ")]
            public string Cnpj { get; set; }

            [JsonProperty("xNome")]
            public XNome XNome { get; set; }

            [JsonProperty("enderEmit")]
            public EnderEmit EnderEmit { get; set; }

            [JsonProperty("IE")]
            public string Ie { get; set; }

            [JsonProperty("IM")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Im { get; set; }

            [JsonProperty("cRegTrib")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CRegTrib { get; set; }

            [JsonProperty("indRatISSQN")]
            public IndRatIssqn IndRatIssqn { get; set; }
        }

        public partial class EnderEmit
        {
            [JsonProperty("xLgr")]
            public XLgr XLgr { get; set; }

            [JsonProperty("nro")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Nro { get; set; }

            [JsonProperty("xCpl")]
            public XCpl XCpl { get; set; }

            [JsonProperty("xBairro")]
            public XBairro XBairro { get; set; }

            [JsonProperty("xMun")]
            public XMun XMun { get; set; }

            [JsonProperty("CEP")]
            public string Cep { get; set; }
        }

        public partial class Ide
        {
            [JsonProperty("cUF")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CUf { get; set; }

            [JsonProperty("cNF")]
            public string CNf { get; set; }

            [JsonProperty("mod")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Mod { get; set; }

            [JsonProperty("nserieSAT")]
            public string NserieSat { get; set; }

            [JsonProperty("nCFe")]
            public string NCFe { get; set; }

            [JsonProperty("dEmi")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long DEmi { get; set; }

            [JsonProperty("hEmi")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long HEmi { get; set; }

            [JsonProperty("cDV")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CDv { get; set; }

            [JsonProperty("tpAmb")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long TpAmb { get; set; }

            [JsonProperty("CNPJ")]
            public string Cnpj { get; set; }

            [JsonProperty("signAC")]
            public string SignAc { get; set; }

            [JsonProperty("assinaturaQRCODE")]
            public string AssinaturaQrcode { get; set; }

            [JsonProperty("numeroCaixa")]
            public string NumeroCaixa { get; set; }
        }

        public partial class InfAdic
        {
            [JsonProperty("infCpl")]
            public Guid InfCpl { get; set; }

            [JsonProperty("obsFisco")]
            public ObsFisco ObsFisco { get; set; }
        }

        public partial class ObsFisco
        {
            [JsonProperty("xTexto")]
            public XTexto XTexto { get; set; }

            [JsonProperty("_xCampo")]
            public XCampo XCampo { get; set; }
        }

        public partial class Pgto
        {
            [JsonProperty("MP")]
            public MpUnion Mp { get; set; }

            [JsonProperty("vTroco")]
            public string VTroco { get; set; }
        }

        public partial class MpElement
        {
            [JsonProperty("cMP")]
            public string CMp { get; set; }

            [JsonProperty("vMP")]
            public string VMp { get; set; }

            [JsonProperty("cAdmC", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? CAdmC { get; set; }
        }

        public partial class Total
        {
            [JsonProperty("ICMSTot")]
            public IcmsTot IcmsTot { get; set; }

            [JsonProperty("vCFe")]
            public string VCFe { get; set; }
        }

        public partial class IcmsTot
        {
            [JsonProperty("vICMS")]
            public string VIcms { get; set; }

            [JsonProperty("vProd")]
            public string VProd { get; set; }

            [JsonProperty("vDesc")]
            public string VDesc { get; set; }

            [JsonProperty("vPIS")]
            public string VPis { get; set; }

            [JsonProperty("vCOFINS")]
            public string VCofins { get; set; }

            [JsonProperty("vPISST")]
            public string VPisst { get; set; }

            [JsonProperty("vCOFINSST")]
            public string VCofinsst { get; set; }

            [JsonProperty("vOutro")]
            public string VOutro { get; set; }
        }

        public partial class Signature
        {
            [JsonProperty("SignedInfo")]
            public SignedInfo SignedInfo { get; set; }

            [JsonProperty("SignatureValue")]
            public string SignatureValue { get; set; }

            [JsonProperty("KeyInfo")]
            public KeyInfo KeyInfo { get; set; }

            [JsonProperty("_xmlns")]
            public Uri Xmlns { get; set; }
        }

        public partial class KeyInfo
        {
            [JsonProperty("X509Data")]
            public X509Data X509Data { get; set; }
        }

        public partial class X509Data
        {
            [JsonProperty("X509Certificate")]
            public string X509Certificate { get; set; }
        }

        public partial class SignedInfo
        {
            [JsonProperty("CanonicalizationMethod")]
            public CanonicalizationMethod CanonicalizationMethod { get; set; }

            [JsonProperty("SignatureMethod")]
            public CanonicalizationMethod SignatureMethod { get; set; }

            [JsonProperty("Reference")]
            public Reference Reference { get; set; }
        }

        public partial class CanonicalizationMethod
        {
            [JsonProperty("_Algorithm")]
            public Uri Algorithm { get; set; }
        }

        public partial class Reference
        {
            [JsonProperty("Transforms")]
            public Transforms Transforms { get; set; }

            [JsonProperty("DigestMethod")]
            public CanonicalizationMethod DigestMethod { get; set; }

            [JsonProperty("DigestValue")]
            public string DigestValue { get; set; }

            [JsonProperty("_URI")]
            public string Uri { get; set; }
        }

        public partial class Transforms
        {
            [JsonProperty("Transform")]
            public CanonicalizationMethod[] Transform { get; set; }
        }

        public enum IndRegra { T };

        public enum XCampoDet { CodCest };

        public enum UCom { Un };

        public enum XBairro { ColoniaZonaLeste };

        public enum XCpl { NaoInformado };

        public enum XLgr { EstradaDoPessego };

        public enum XMun { SaoPaulo };

        public enum IndRatIssqn { S };

        public enum XNome { AutoPostoAuroraIiLtda };

        public enum XCampo { The05070504 };

        public enum XTexto { CometeCrimeQuemSonega };

        public partial struct DetUnion
        {
            public DetElement DetElement;
            public DetElement[] DetElementArray;

            public static implicit operator DetUnion(DetElement DetElement) => new DetUnion { DetElement = DetElement };
            public static implicit operator DetUnion(DetElement[] DetElementArray) => new DetUnion { DetElementArray = DetElementArray };
        }

        public partial struct MpUnion
        {
            public MpElement MpElement;
            public MpElement[] MpElementArray;

            public static implicit operator MpUnion(MpElement MpElement) => new MpUnion { MpElement = MpElement };
            public static implicit operator MpUnion(MpElement[] MpElementArray) => new MpUnion { MpElementArray = MpElementArray };
        }

        public partial class RootObjectCfeJson
        {
            public static RootObjectCfeJson FromJson(string json) => JsonConvert.DeserializeObject<RootObjectCfeJson>(json, Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this RootObjectCfeJson self) => JsonConvert.SerializeObject(self, Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                DetUnionConverter.Singleton,
                IndRegraConverter.Singleton,
                XCampoDetConverter.Singleton,
                UComConverter.Singleton,
                XBairroConverter.Singleton,
                XCplConverter.Singleton,
                XLgrConverter.Singleton,
                XMunConverter.Singleton,
                IndRatIssqnConverter.Singleton,
                XNomeConverter.Singleton,
                XCampoConverter.Singleton,
                XTextoConverter.Singleton,
                MpUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        internal class DetUnionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DetUnion) || t == typeof(DetUnion?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<DetElement>(reader);
                        return new DetUnion { DetElement = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<DetElement[]>(reader);
                        return new DetUnion { DetElementArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type DetUnion");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (DetUnion)untypedValue;
                if (value.DetElementArray != null)
                {
                    serializer.Serialize(writer, value.DetElementArray);
                    return;
                }
                if (value.DetElement != null)
                {
                    serializer.Serialize(writer, value.DetElement);
                    return;
                }
                throw new Exception("Cannot marshal type DetUnion");
            }

            public static readonly DetUnionConverter Singleton = new DetUnionConverter();
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }
                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (long)untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }

        internal class IndRegraConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(IndRegra) || t == typeof(IndRegra?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "T")
                {
                    return IndRegra.T;
                }
                throw new Exception("Cannot unmarshal type IndRegra");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (IndRegra)untypedValue;
                if (value == IndRegra.T)
                {
                    serializer.Serialize(writer, "T");
                    return;
                }
                throw new Exception("Cannot marshal type IndRegra");
            }

            public static readonly IndRegraConverter Singleton = new IndRegraConverter();
        }

        internal class XCampoDetConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XCampoDet) || t == typeof(XCampoDet?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Cod. CEST")
                {
                    return XCampoDet.CodCest;
                }
                throw new Exception("Cannot unmarshal type XCampoDet");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XCampoDet)untypedValue;
                if (value == XCampoDet.CodCest)
                {
                    serializer.Serialize(writer, "Cod. CEST");
                    return;
                }
                throw new Exception("Cannot marshal type XCampoDet");
            }

            public static readonly XCampoDetConverter Singleton = new XCampoDetConverter();
        }

        internal class UComConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(UCom) || t == typeof(UCom?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "UN")
                {
                    return UCom.Un;
                }
                throw new Exception("Cannot unmarshal type UCom");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (UCom)untypedValue;
                if (value == UCom.Un)
                {
                    serializer.Serialize(writer, "UN");
                    return;
                }
                throw new Exception("Cannot marshal type UCom");
            }

            public static readonly UComConverter Singleton = new UComConverter();
        }

        internal class XBairroConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XBairro) || t == typeof(XBairro?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "COLONIA ZONA LESTE")
                {
                    return XBairro.ColoniaZonaLeste;
                }
                throw new Exception("Cannot unmarshal type XBairro");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XBairro)untypedValue;
                if (value == XBairro.ColoniaZonaLeste)
                {
                    serializer.Serialize(writer, "COLONIA ZONA LESTE");
                    return;
                }
                throw new Exception("Cannot marshal type XBairro");
            }

            public static readonly XBairroConverter Singleton = new XBairroConverter();
        }

        internal class XCplConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XCpl) || t == typeof(XCpl?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Nao Informado")
                {
                    return XCpl.NaoInformado;
                }
                throw new Exception("Cannot unmarshal type XCpl");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XCpl)untypedValue;
                if (value == XCpl.NaoInformado)
                {
                    serializer.Serialize(writer, "Nao Informado");
                    return;
                }
                throw new Exception("Cannot marshal type XCpl");
            }

            public static readonly XCplConverter Singleton = new XCplConverter();
        }

        internal class XLgrConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XLgr) || t == typeof(XLgr?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "ESTRADA DO PESSEGO")
                {
                    return XLgr.EstradaDoPessego;
                }
                throw new Exception("Cannot unmarshal type XLgr");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XLgr)untypedValue;
                if (value == XLgr.EstradaDoPessego)
                {
                    serializer.Serialize(writer, "ESTRADA DO PESSEGO");
                    return;
                }
                throw new Exception("Cannot marshal type XLgr");
            }

            public static readonly XLgrConverter Singleton = new XLgrConverter();
        }

        internal class XMunConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XMun) || t == typeof(XMun?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "SAO PAULO")
                {
                    return XMun.SaoPaulo;
                }
                throw new Exception("Cannot unmarshal type XMun");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XMun)untypedValue;
                if (value == XMun.SaoPaulo)
                {
                    serializer.Serialize(writer, "SAO PAULO");
                    return;
                }
                throw new Exception("Cannot marshal type XMun");
            }

            public static readonly XMunConverter Singleton = new XMunConverter();
        }

        internal class IndRatIssqnConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(IndRatIssqn) || t == typeof(IndRatIssqn?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "S")
                {
                    return IndRatIssqn.S;
                }
                throw new Exception("Cannot unmarshal type IndRatIssqn");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (IndRatIssqn)untypedValue;
                if (value == IndRatIssqn.S)
                {
                    serializer.Serialize(writer, "S");
                    return;
                }
                throw new Exception("Cannot marshal type IndRatIssqn");
            }

            public static readonly IndRatIssqnConverter Singleton = new IndRatIssqnConverter();
        }

        internal class XNomeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XNome) || t == typeof(XNome?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "AUTO POSTO AURORA II LTDA")
                {
                    return XNome.AutoPostoAuroraIiLtda;
                }
                throw new Exception("Cannot unmarshal type XNome");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XNome)untypedValue;
                if (value == XNome.AutoPostoAuroraIiLtda)
                {
                    serializer.Serialize(writer, "AUTO POSTO AURORA II LTDA");
                    return;
                }
                throw new Exception("Cannot marshal type XNome");
            }

            public static readonly XNomeConverter Singleton = new XNomeConverter();
        }

        internal class XCampoConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XCampo) || t == typeof(XCampo?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "05.07.05.04")
                {
                    return XCampo.The05070504;
                }
                throw new Exception("Cannot unmarshal type XCampo");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XCampo)untypedValue;
                if (value == XCampo.The05070504)
                {
                    serializer.Serialize(writer, "05.07.05.04");
                    return;
                }
                throw new Exception("Cannot marshal type XCampo");
            }

            public static readonly XCampoConverter Singleton = new XCampoConverter();
        }

        internal class XTextoConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(XTexto) || t == typeof(XTexto?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Comete crime quem sonega")
                {
                    return XTexto.CometeCrimeQuemSonega;
                }
                throw new Exception("Cannot unmarshal type XTexto");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (XTexto)untypedValue;
                if (value == XTexto.CometeCrimeQuemSonega)
                {
                    serializer.Serialize(writer, "Comete crime quem sonega");
                    return;
                }
                throw new Exception("Cannot marshal type XTexto");
            }

            public static readonly XTextoConverter Singleton = new XTextoConverter();
        }

        internal class MpUnionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(MpUnion) || t == typeof(MpUnion?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<MpElement>(reader);
                        return new MpUnion { MpElement = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<MpElement[]>(reader);
                        return new MpUnion { MpElementArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type MpUnion");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (MpUnion)untypedValue;
                if (value.MpElementArray != null)
                {
                    serializer.Serialize(writer, value.MpElementArray);
                    return;
                }
                if (value.MpElement != null)
                {
                    serializer.Serialize(writer, value.MpElement);
                    return;
                }
                throw new Exception("Cannot marshal type MpUnion");
            }

            public static readonly MpUnionConverter Singleton = new MpUnionConverter();
        }
}
