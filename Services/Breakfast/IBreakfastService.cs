﻿using BuberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.breakfast
{
    public interface IBreakfastService
    {
        void CreateBreakfast(Breakfast breakfast);
        BreakfastRespons GetBreakfast(Guid Id);
        BreakfastRespons UpdateBreakfast(Guid id, UpsertBreakfastRequest request);
        BreakfastRespons DeleteBreakfast(Guid id);
    }
}