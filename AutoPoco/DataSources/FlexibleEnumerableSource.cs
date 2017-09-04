namespace AutoPoco.DataSources
{
    using System;
    using System.Collections.Generic;

    using AutoPoco.Engine;

    public class FlexibleEnumerableSource<TSource, TCollectionType, TCollectionElement> : IDatasource<TCollectionType>
        where TCollectionType : IEnumerable<TCollectionElement> 
        where TSource : DatasourceBase<TCollectionElement> 
        
    {
        private readonly EnumerableSource<TSource, TCollectionElement> innerSource;
        
        public FlexibleEnumerableSource(int count)
            : this(count, count, new object[] { })
        { }

        public FlexibleEnumerableSource(int min, int max)
            : this(min, max, new object[] { })
        { }

        public FlexibleEnumerableSource(int minCount, int maxCount, params object[] args)
        {
            this.innerSource = new EnumerableSource<TSource, TCollectionElement>(minCount, maxCount, args);
        }

        object IDatasource.Next(IGenerationContext context)
        {
            var propertyCollection = (ICollection<TCollectionElement>)Activator.CreateInstance(typeof(TCollectionType));
            var collectionContents = this.innerSource.Next(context);

            foreach (TCollectionElement item in collectionContents)
            {
                propertyCollection.Add(item);
            }
            return propertyCollection;
        }
    }
}