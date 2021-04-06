using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    

    public class GetCookiesForWebsiteQuery : Query<GetCookiesForWebsiteResult>
    {
        public override string Alias => "GetCookiesForWebsite";

        public Guid WebsiteKey { get; set; }

    }

    public class GetCookiesForWebsiteResult
    {
        public string WebsiteName {get;set;}

        


    }

    public abstract class Query<T> : IQuery<T>
    {
        public abstract string Alias { get; }
        
    }

    public interface IQuery
    {
        /// <summary>
        /// Used when performing requests from the front end
        /// </summary>
        string Alias { get; }
        
    }

    
    /// <summary>
    /// Base class for Queries using the <see cref="IMediator"/>
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IQuery<out TResponse> : IQuery
    {
     
    }

}
