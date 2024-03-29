using System;
using System.Collections.Generic;
using Domain_Layer.Base;

namespace Domain_Layer.Entities.Product
{
    public class ProductReviews : BaseEntity
    {
        public ProductReviews(Guid Id,
                            Guid userId,
                            Guid productId, 
                            string comment, 
                            int numberOfStars, 
                            DateTimeOffset dateTimeCreate, 
                            List<string> photo)
        {
            this.userId = userId;
            ProductId = productId;
            Comment = comment;
            this.numberOfStars = numberOfStars;
            this.dateTimeCreate = dateTimeCreate;
            Photo = photo;
            this.Id = Id;
        }
        public ProductReviews()
        {
            
        }

        public Guid userId {get; set;}
        public Guid ProductId {get; set;}
        public string Comment {get; set;}
        public int numberOfStars {get; set;}
        public DateTimeOffset dateTimeCreate {get; set;}
        public List<string> Photo {get; set;} 
        
    }
}