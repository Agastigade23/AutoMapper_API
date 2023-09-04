using AutoMapper;
using AutoMapper_API.Entities;
using AutoMapper_API.Repositories;
using AutoMapper_API.Resources;
using ErrorOr;
using MediatR;

namespace AutoMapper_API.Handlers.Queries
{
    public class GetPersonByIdQuery : IRequest<ErrorOr<PersonResource>>
    {
        public int Id { get; }
        public GetPersonByIdQuery(int id)
        {
            Id = id;
        }
    
    }

    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, ErrorOr<PersonResource>>
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GetPersonByIdQueryHandler(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<ErrorOr<PersonResource>> Handle(GetPersonByIdQuery request,
            CancellationToken cancellationToken)
        {
            var employee = await _uow.Repository().GetById<Person>(request.Id);
            //var address = await _uow.Repository().GetById<Address>(request.Id);
            if (employee is null)
                return Error.NotFound(code: "Person not found", description: "Please enter the existing Person Id");
            //var test= _mapper.Map<AddressResource>(address);
            //var test2= _mapper.Map<PersonResource>(employee);
            return _mapper.Map<PersonResource>(employee);
        }
    }
}
