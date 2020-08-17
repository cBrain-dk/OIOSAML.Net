using System;
using System.Xml.Serialization;

namespace dk.nita.saml20.Schema.Metadata
{
  /// <summary>
  /// The &lt;SecurityTokenServiceType&gt; element extends RoleDescriptorType.
  /// </summary>

  [Serializable]
  [XmlType(Namespace = Saml20Constants.FEDERATION, TypeName = nameof(SecurityTokenServiceType))]
  [XmlRoot(ELEMENT_NAME, Namespace = Saml20Constants.METADATA, IsNullable = false)]
  public class SecurityTokenServiceType : RoleDescriptor
  {
    /// <summary>
    /// .
    /// </summary>
    public SecurityTokenServiceType()
    {
    }
  }
}
