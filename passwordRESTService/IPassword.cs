using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace passwordRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPassword
    {
        

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ytComments/{id}")]
        Comments ytComments(string id);

        // TODO: Add your service operations here


    }
    [DataContract]
    public class Comments
    {

        [DataMember]
        public string allComments { get; set; }

    }

    /*
    [DataContract]
    public class Comment
    {
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string commentBody { get; set; }
    }

    [DataContract]
    public class Comments
    {
        
        [DataMember]
        public List<Comment> allComments { get; set; }

    }
    */










}
