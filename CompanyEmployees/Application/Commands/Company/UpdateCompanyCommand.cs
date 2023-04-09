﻿using System;
using MediatR;
using Shared.DataTransferObjects;

namespace Application.Commands.Company;

public sealed record UpdateCompanyCommand(Guid Id, CompanyForUpdateDto Company, bool TrackChanges) : IRequest<Unit>;

