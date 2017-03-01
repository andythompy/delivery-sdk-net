﻿using Newtonsoft.Json.Linq;

namespace KenticoCloud.Delivery
{
    /// <summary>
    /// Represents an option of a Multiple choice content element.
    /// </summary>
    public sealed class MultipleChoiceContentElementOption
    {
        /// <summary>
        /// Gets the name of the option.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the codename of the option.
        /// </summary>
        public string Codename { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleChoiceContentElementOption"/> class with the specified JSON data.
        /// </summary>
        /// <param name="source">The JSON data to deserialize.</param>
        internal MultipleChoiceContentElementOption(JToken source)
        {
            Name = source["name"].ToString();
            Codename = source["codename"].ToString();
        }
    }
}