using dk.nita.saml20.Schema.Core;
using dk.nita.saml20.Schema.Protocol;

namespace dk.nita.saml20.Validation
{
    public interface ISaml20AttributeValidator
    {
        void ValidateAttribute(SamlAttribute samlAttribute);
        void ValidateEncryptedAttribute(EncryptedElement encryptedElement);
    }
}