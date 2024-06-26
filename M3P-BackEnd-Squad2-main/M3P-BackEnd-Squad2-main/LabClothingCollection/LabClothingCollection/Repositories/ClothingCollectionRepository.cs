﻿using LabClothingCollection.Context;
using LabClothingCollection.Models;
using LabClothingCollection.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace LabClothingCollection.Repositories
{
    public class ClothingCollectionRepository : IClothingCollectionRepository
    {

        private readonly LCCContext _lccContext;

        public ClothingCollectionRepository(LCCContext lccContext)
        {
            _lccContext = lccContext;
        }
        public void CreateClothingCollection(ClothingCollection clothingCollection)
        {
            _lccContext.Collections.Add(clothingCollection);
        }

        public void DeleteClothingCollection(ClothingCollection clothingCollection)
        {
            _lccContext.Collections.Remove(clothingCollection);
        }

        public async Task<ClothingCollection> GetClothingCollectionById(int id)
        {
            return await _lccContext.Collections.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ClothingCollection>> GetClothingCollections()
        {
            return await _lccContext.Collections.Include(x => x.User).ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _lccContext.SaveChangesAsync() > 0;
        }

        public void UpdateClothingCollection(ClothingCollection clothingCollection)
        {
            _lccContext.Entry(clothingCollection).State = EntityState.Modified;
        }
    }
}
