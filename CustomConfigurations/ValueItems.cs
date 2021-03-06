﻿using System;
using System.Configuration;

namespace CustomConfigurations
{

    /// <summary>
    /// Object to hold a list of valueItemElements
    /// </summary>
    public class ValueItemElementCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ValueItemElement();
        }

        protected override string ElementName
        {
            get { return "ValueItem"; }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }  

        /// <summary>
        /// Gets the element key for a specified configuration element when overridden in a derived class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Object"/> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement"/> to return the key for. 
        ///                 </param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ValueItemElement)element).Key;
        }

        public ValueItemElement this[int index]
        {
            get { return BaseGet(index) as ValueItemElement; }
        }

        public new ValueItemElement this[string key]
        {
            get { return BaseGet(key) as ValueItemElement; }
        }
    }





    /// <summary>
    /// An Object to Hold a single key value pair.
    /// </summary>
    public class ValueItemElement : ConfigurationElement
    {
        [ConfigurationProperty("key", IsRequired = true, IsKey = true)]
        public String Key
        {
            get
            {
                return this["key"].ToString();
            }
        }

        [ConfigurationProperty("value", IsRequired = true, IsKey = false)]
        public String Value
        {
            get
            {
                return this["value"].ToString();
            }
        }
    }
}
