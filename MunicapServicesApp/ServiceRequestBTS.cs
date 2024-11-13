using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicapServicesApp
{
    public class ServiceRequestBTS
    {
        public class TreeNode
        {
            public ServiceRequest Request { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(ServiceRequest request)
            {
                Request = request;
                Left = null;
                Right = null;
            }
        }

        private TreeNode root;

        public ServiceRequestBTS()
        {
            root = null;
        }

        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private TreeNode InsertRec(TreeNode root, ServiceRequest request)
        {
            if (root == null)
            {
                root = new TreeNode(request);
                return root;
            }

            if (string.Compare(request.Id, root.Request.Id) < 0)
                root.Left = InsertRec(root.Left, request);
            else if (string.Compare(request.Id, root.Request.Id) > 0)
                root.Right = InsertRec(root.Right, request);

            return root;
        }

        public ServiceRequest Search(string requestId)
        {
            return SearchRec(root, requestId);
        }

        private ServiceRequest SearchRec(TreeNode root, string requestId)
        {
            if (   root.Request == null || root.Request.Id == requestId)
                return root?.Request;

            if (string.Compare(requestId, root.Request.Id) < 0)
                return SearchRec(root.Left, requestId);
            else
                return SearchRec(root.Right, requestId);
        }

        public List<ServiceRequest> GetAllRequests()
        {
            List<ServiceRequest> requests = new List<ServiceRequest>();
            InOrderTraversal(root, requests);
            return requests;
        }

        private void InOrderTraversal(TreeNode node, List<ServiceRequest> requests )
        {
            InOrderTraversal(node.Left, requests);
            requests.Add(node.Request);
            InOrderTraversal(node.Right, requests);
        }
    }
}
