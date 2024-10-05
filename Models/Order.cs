namespace ASM.Models
{
    public class AdminViewModel
    {
        public List<Order> Orders { get; set; }
        public AdminInfo CurrentAdmin { get; set; } // Thêm thông tin quản trị viên
    }

    public class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }

    public class AdminInfo
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    public class DangNhap
    {
        public string Email { get; set; }
        public string matkhau { get; set; }
    }
    public class Dangky

    {
        
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public string NhapLaiMatKhau { get; set; }
    }
}