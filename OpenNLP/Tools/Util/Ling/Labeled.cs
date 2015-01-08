﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Ling
{
    /// <summary>
    /// A <code>LabeledScoredTreeFactory</code> acts as a factory for creating
    /// trees with labels and scores.  Unless another <code>LabelFactory</code>
    /// is supplied, it will use a <code>CoreLabel</code> by default.
    /// 
    /// @author Christopher Manning
    /// 
    /// Code...
    /// </summary>
    public interface Labeled
    {
        
        /// <summary>
        /// Returns one of the labels of the object (if there are multiple labels,
        /// preferably the primary label, if it exists).
        /// Returns null if there is no label.
        /// </summary>
        Label Label();

        /// <summary>
        /// Sets the label associated with this object.
        /// </summary>
        /// <param name="label">The Label value</param>
        void SetLabel(Label label);

        /// <summary>
        /// Gives back all labels for this thing.
        /// </summary>
        /// <returns>
        /// A Collection of the Object's labels.
        /// Returns an empty Collection if there are no labels.
        /// </returns>
        ICollection<Label> Labels();

        /// <summary>
        /// Sets the labels associated with this object.
        /// </summary>
        /// <param name="labels">The set of Label values</param>
        void SetLabels(ICollection<Label> labels);
    }
}