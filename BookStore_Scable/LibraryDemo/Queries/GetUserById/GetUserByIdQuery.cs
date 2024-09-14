﻿using LibraryDemo.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo.Queries.GetUserById
{
    public record GetUserByIdQuery(int Id) : IRequest<User>;
}
