﻿using System;

namespace RepoDb.Exceptions
{
    /// <summary>
    /// An exception that is being thrown if the data entity is not mergeable.
    /// </summary>
    public class EntityNotMergeableException : Exception
    {
        /// <summary>
        /// Creates a new instance of <i>RepoDb.Exceptions.EntityNotMergeableException</i> object.
        /// </summary>
        /// <param name="name">The type name or the mapped name of the entity.</param>
        public EntityNotMergeableException(string name)
            : base($"Cannot Merge: {name}") { }
    }
}
