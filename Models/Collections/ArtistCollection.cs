﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ArtAuction.Models.Collections
{
    public class ArtistCollection : IEditableCollection<Artist>
    {
        private readonly IMongoCollection<Artist> _artists;

        public ArtistCollection(string conStr)
        {
            var client = new MongoClient(conStr);
            var database = client.GetDatabase("ArtDB");
            _artists = database.GetCollection<Artist>("Artists");
        }

        public List<Artist> Objects
        {
            get
            {
                return _artists.Find(_ => true).ToList();
            }
        }

        public void AddObject(Artist obj)
        {
            _artists.InsertOne(obj);
        }

        public void RemoveObject(string id)
        {
            _artists.DeleteOne(ar => ar.Id == id);
        }

        public void UpdateObject(Artist obj)
        {
            var filter = new BsonDocument("_id", new ObjectId(obj.Id));
            var res = _artists.ReplaceOne(filter, obj);
        }

        public Artist FindObject(string id)
        {
            var artistFound = _artists.Find(ar => ar.Id == id).ToList();
            return artistFound[0];
        }

    }
}
