﻿using GraphQL.Types;

namespace GraphQlProject.Type
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<StringGraphType>("imageUrl");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("menuId");
        }
    }
}