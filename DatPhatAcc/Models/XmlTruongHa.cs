using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatPhatAcc.Models
{
    [XmlRoot(ElementName = "HDon")]
    public class HDon
    {

        [XmlElement(ElementName = "DLHDon")]
        public DLHDon DLHDon { get; set; }

        //[XmlElement(ElementName = "DSCKS")]
        //public DSCKS DSCKS { get; set; }

        //[XmlElement(ElementName = "Fkey")]
        //public string Fkey { get; set; }

        //[XmlElement(ElementName = "QRCode")]
        //public object QRCode { get; set; }
    }

    [XmlRoot(ElementName = "DLHDon")]
    public class DLHDon
    {

        [XmlElement(ElementName = "TTChung")]
        public TTChung TTChung { get; set; }

        [XmlElement(ElementName = "NDHDon")]
        public NDHDon NDHDon { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; } = string.Empty;

        [XmlText]
        public string Text { get; set; } = string.Empty;
    }


    [XmlRoot(ElementName = "TTChung")]
    public class TTChung
    {

        [XmlElement(ElementName = "PBan")]
        public string PBan { get; set; } = string.Empty;

        [XmlElement(ElementName = "THDon")]
        public string THDon { get; set; } = string.Empty;

        [XmlElement(ElementName = "KHMSHDon")]
        public string KHMSHDon { get; set; } = string.Empty;

        [XmlElement(ElementName = "KHHDon")]
        public string KHHDon { get; set; } = string.Empty;

        [XmlElement(ElementName = "SHDon")]
        public string SHDon { get; set; } = string.Empty;

        [XmlElement(ElementName = "NLap")]
        public string NLap { get; set; } = string.Empty;

        [XmlElement(ElementName = "DVTTe")]
        public string DVTTe { get; set; } = string.Empty;

        [XmlElement(ElementName = "TGia")]
        public string TGia { get; set; } = string.Empty;

        [XmlElement(ElementName = "HTTToan")]
        public string HTTToan { get; set; } = string.Empty;

        [XmlElement(ElementName = "MSTTCGP")]
        public string MSTTCGP { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "NBan")]
    public class NBan
    {

        [XmlElement(ElementName = "Ten")]
        public string Ten { get; set; } = string.Empty;

        [XmlElement(ElementName = "MST")]
        public string MST { get; set; } = string.Empty;

        [XmlElement(ElementName = "DChi")]
        public string DChi { get; set; } = string.Empty;

        [XmlElement(ElementName = "SDThoai")]
        public string SDThoai { get; set; } = string.Empty;

        [XmlElement(ElementName = "STKNHang")]
        public string STKNHang { get; set; } = string.Empty;

        [XmlElement(ElementName = "TNHang")]
        public string TNHang { get; set; } = string.Empty;

        [XmlElement(ElementName = "Signature")]
        public Signature Signature { get; set; }
    }

    [XmlRoot(ElementName = "NMua")]
    public class NMua
    {

        [XmlElement(ElementName = "Ten")]
        public string Ten { get; set; } = string.Empty;

        [XmlElement(ElementName = "MST")]
        public string MST { get; set; } = string.Empty;

        [XmlElement(ElementName = "DChi")]
        public string DChi { get; set; } = string.Empty;

        [XmlElement(ElementName = "MKHang")]
        public string MKHang { get; set; } = string.Empty;

        [XmlElement(ElementName = "DCTDTu")]
        public string DCTDTu { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "TTin")]
    public class TTin
    {

        [XmlElement(ElementName = "TTruong")]
        public string TTruong { get; set; } = string.Empty;

        [XmlElement(ElementName = "KDLieu")]
        public string KDLieu { get; set; } = string.Empty;

        [XmlElement(ElementName = "DLieu")]
        public string DLieu { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "TTKhac")]
    public class TTKhac
    {

        [XmlElement(ElementName = "TTin")]
        public List<TTin> TTin { get; set; }
    }

    [XmlRoot(ElementName = "HHDVu")]
    public class HHDVu
    {

        [XmlElement(ElementName = "TChat")]
        public string TChat { get; set; } = string.Empty;

        [XmlElement(ElementName = "STT")]
        public string STT { get; set; } = string.Empty;

        [XmlElement(ElementName = "MHHDVu")]
        public string MHHDVu { get; set; } = string.Empty;

        [XmlElement(ElementName = "THHDVu")]
        public string THHDVu { get; set; } = string.Empty;

        [XmlElement(ElementName = "DVTinh")]
        public string DVTinh { get; set; } = string.Empty;

        [XmlElement(ElementName = "SLuong")]
        public string SLuong { get; set; } = string.Empty;

        [XmlElement(ElementName = "DGia")]
        public string DGia { get; set; } = string.Empty;

        [XmlElement(ElementName = "TLCKhau")]
        public string TLCKhau { get; set; } = string.Empty;

        [XmlElement(ElementName = "STCKhau")]
        public string STCKhau { get; set; } = string.Empty;

        [XmlElement(ElementName = "TSuat")]
        public string TSuat { get; set; } = string.Empty;

        [XmlElement(ElementName = "ThTien")]
        public string ThTien { get; set; } = string.Empty;

        [XmlElement(ElementName = "TTKhac")]
        public TTKhac TTKhac { get; set; }
    }

    [XmlRoot(ElementName = "DSHHDVu")]
    public class DSHHDVu
    {

        [XmlElement(ElementName = "HHDVu")]
        public List<HHDVu> HHDVu { get; set; }
    }

    [XmlRoot(ElementName = "LTSuat")]
    public class LTSuat
    {

        [XmlElement(ElementName = "TSuat")]
        public string TSuat { get; set; } = string.Empty;

        [XmlElement(ElementName = "TThue")]
        public string TThue { get; set; } = string.Empty;

        [XmlElement(ElementName = "ThTien")]
        public string ThTien { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "THTTLTSuat")]
    public class THTTLTSuat
    {

        [XmlElement(ElementName = "LTSuat")]
        public LTSuat LTSuat { get; set; }
    }

    [XmlRoot(ElementName = "TToan")]
    public class TToan
    {

        [XmlElement(ElementName = "THTTLTSuat")]
        public THTTLTSuat THTTLTSuat { get; set; }

        [XmlElement(ElementName = "TgTCThue")]
        public string TgTCThue { get; set; } = string.Empty;

        [XmlElement(ElementName = "TgTThue")]
        public string TgTThue { get; set; } = string.Empty;

        [XmlElement(ElementName = "TgTTTBSo")]
        public string TgTTTBSo { get; set; } = string.Empty;

        [XmlElement(ElementName = "TgTTTBChu")]
        public string TgTTTBChu { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "NDHDon")]
    public class NDHDon
    {

        [XmlElement(ElementName = "NBan")]
        public NBan NBan { get; set; }

        [XmlElement(ElementName = "NMua")]
        public NMua NMua { get; set; }

        [XmlElement(ElementName = "DSHHDVu")]
        public DSHHDVu DSHHDVu { get; set; }

        [XmlElement(ElementName = "TToan")]
        public TToan TToan { get; set; }
    }

   

    [XmlRoot(ElementName = "CanonicalizationMethod")]
    public class CanonicalizationMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "SignatureMethod")]
    public class SignatureMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transform")]
    public class Transform
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transforms")]
    public class Transforms
    {

        [XmlElement(ElementName = "Transform")]
        public Transform Transform { get; set; }
    }

    [XmlRoot(ElementName = "DigestMethod")]
    public class DigestMethod
    {

        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Reference")]
    public class Reference
    {

        [XmlElement(ElementName = "Transforms")]
        public Transforms Transforms { get; set; }

        [XmlElement(ElementName = "DigestMethod")]
        public DigestMethod DigestMethod { get; set; }

        [XmlElement(ElementName = "DigestValue")]
        public string DigestValue { get; set; }

        [XmlAttribute(AttributeName = "URI")]
        public string URI { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SignedInfo")]
    public class SignedInfo
    {

        [XmlElement(ElementName = "CanonicalizationMethod")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }

        [XmlElement(ElementName = "SignatureMethod")]
        public SignatureMethod SignatureMethod { get; set; }

        [XmlElement(ElementName = "Reference")]
        public List<Reference> Reference { get; set; }
    }

    [XmlRoot(ElementName = "X509Data")]
    public class X509Data
    {

        [XmlElement(ElementName = "X509SubjectName")]
        public string X509SubjectName { get; set; }

        [XmlElement(ElementName = "X509Certificate")]
        public string X509Certificate { get; set; }
    }

    [XmlRoot(ElementName = "KeyInfo")]
    public class KeyInfo
    {

        [XmlElement(ElementName = "X509Data")]
        public X509Data X509Data { get; set; }
    }

    [XmlRoot(ElementName = "SignatureProperty")]
    public class SignatureProperty
    {

        [XmlElement(ElementName = "SigningTime")]
        public DateTime SigningTime { get; set; }

        [XmlAttribute(AttributeName = "Target")]
        public string Target { get; set; }

        [XmlText]
        public DateTime Text { get; set; }
    }

    [XmlRoot(ElementName = "SignatureProperties")]
    public class SignatureProperties
    {

        [XmlElement(ElementName = "SignatureProperty")]
        public SignatureProperty SignatureProperty { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public object Xmlns { get; set; }

        [XmlText]
        public DateTime Text { get; set; }
    }

    [XmlRoot(ElementName = "Object")]
    public class Object1
    {

        [XmlElement(ElementName = "SignatureProperties")]
        public SignatureProperties SignatureProperties { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlText]
        public DateTime Text { get; set; }
    }

    [XmlRoot(ElementName = "Signature")]
    public class Signature
    {

        [XmlElement(ElementName = "SignedInfo")]
        public SignedInfo SignedInfo { get; set; }

        [XmlElement(ElementName = "SignatureValue")]
        public string SignatureValue { get; set; }

        [XmlElement(ElementName = "KeyInfo")]
        public KeyInfo KeyInfo { get; set; }

        [XmlElement(ElementName = "Object")]
        public Object Object { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DSCKS")]
    public class DSCKS
    {

        [XmlElement(ElementName = "NBan")]
        public NBan NBan { get; set; }
    }

   
}
