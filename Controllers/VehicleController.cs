using Microsoft.AspNetCore.Mvc;


namespace TanksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly DataContext _context;

        public VehicleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> Get(int userId)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.userId == userId)
                .Include(v => v.Weapon)
                .ToListAsync();
            return vehicles;
        }


        [HttpPost]
        public async Task<ActionResult<List<Vehicle>>> Create(CreateVehicleDto request)
        {
            var user = await _context.Users.FindAsync(request.userId);

            if (user == null)
                return NotFound();

            var newVehicle = new Vehicle
            {
                Name = request.Name,
                VehicleType = request.VehicleType,
                User = user
            };

            _context.Vehicles.Add(newVehicle);
            await _context.SaveChangesAsync();

            return await Get(newVehicle.userId);

        }

        [HttpPost("weapon")]
        public async Task<ActionResult<Vehicle>> AddWeapon(AddWeaponDto request)
        {
            var vehicle = await _context.Vehicles.FindAsync(request.VehicleId);

            if (vehicle == null)
                return NotFound();

            var newWeapon = new Weapon
            {
                Name = request.Name,
                Damage = request.Damage,
                Vehicle = vehicle
            };

            _context.Weapons.Add(newWeapon);
            await _context.SaveChangesAsync();

            return vehicle;

        }
    }
}
