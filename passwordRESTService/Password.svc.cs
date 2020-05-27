using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static passwordRESTService.IPassword;

namespace passwordRESTService
{
    
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Password : IPassword
    {
        
        public Comments ytComments(string id)
        {
            Comments c = new Comments();
            
            

            string url = @"https://www.googleapis.com/youtube/v3/commentThreads?part=snippet&videoId=" + id + "&maxResults=5&key={API_key}&order=relevance";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            

            RootObject commentsObject = JsonConvert.DeserializeObject<RootObject>(responsereader);
            
            int size = commentsObject.items.Count;
            string result = "";

            //compiles list of author and comment body text into a string for output
            //labels author and body 
            for (int i =0; i<size;i++ )
            {
              
                result += "author: " + commentsObject.items[i].snippet.topLevelComment.snippet.authorDisplayName + "\nbody: " + commentsObject.items[i].snippet.topLevelComment.snippet.textDisplay + "\n\n";
            }

            
            c.allComments = result ;



            return c;
        }

    }
}


//structur of json returned for comment list
public class Snippet1
{
    public string authorDisplayName { get; set; }
    public string textDisplay { get; set; }
}

public class TopLevelComment
{
    public string kind { get; set; }
    public string etag { get; set; }
    public string id { get; set; }
    public Snippet1 snippet { get; set; }
}

public class Snippet
{
    public string videoId { get; set; }
    public TopLevelComment topLevelComment { get; set; }
    public Boolean canReply { get; set; }
    public string totalReplyCount { get; set; }
    public Boolean isPublic { get; set; }
}

public class Items
{
    public string kind { get; set; }
    public string etag { get; set; }
    public string id { get; set; }
    public Snippet snippet { get; set; }
}

public class PageInfo
{
    public int totalResults { get; set; }
    public int resultsPerPage { get; set; }
}

public class RootObject
{
    public string kind { get; set; }
    public string etag { get; set; }
    public string nextPageToken { get; set; }
    public PageInfo pageInfo { get; set; }
    public List<Items> items { get; set; }

}
