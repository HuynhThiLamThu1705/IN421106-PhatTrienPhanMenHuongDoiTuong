# CarDealership – Hệ thống quản lý kinh doanh ô tô

## 1. Giới thiệu

CarDealership là dự án xây dựng hệ thống quản lý kinh doanh ô tô bằng ngôn ngữ C#, sử dụng nền tảng .NET 10.0.

Dự án tập trung áp dụng lập trình hướng đối tượng, nguyên lý SOLID và các Design Patterns nhằm xây dựng mã nguồn có cấu trúc rõ ràng, dễ bảo trì và mở rộng.

## 2. Công nghệ sử dụng

- Ngôn ngữ: C#
- Framework: .NET 10.0
- IDE: Visual Studio
- Unit Testing: xUnit
- Quản lý mã nguồn: Git và GitHub

## 3. Cấu trúc dự án

```text
CarDealership/
├── CarDealership.Domain/
│   ├── Entities/
│   ├── Interfaces/
│   ├── Factories/
│   ├── Strategies/
│   ├── Decorators/
│   └── Observers/
│
├── CarDealership.Tests/
│   ├── OrderDecoratorTests.cs
│   ├── OrderFactoryTests.cs
│   ├── OrderObserverTests.cs
│   └── UnitTest1.cs
│
├── CarDealership.slnx
└── README.md
```

## 4. Design Patterns áp dụng

Dự án sử dụng 4 Design Patterns:

- **Factory Pattern:** Quản lý việc khởi tạo đơn hàng.
- **Strategy Pattern:** Xây dựng các chính sách chiết khấu linh hoạt.
- **Decorator Pattern:** Bổ sung dịch vụ bảo hành mở rộng cho đơn hàng.
- **Observer Pattern:** Theo dõi và thông báo trạng thái đơn hàng.

## 5. Nguyên lý SOLID

Dự án hướng đến áp dụng 5 nguyên lý SOLID:

- **SRP:** Mỗi lớp đảm nhiệm một trách nhiệm riêng.
- **OCP:** Cho phép mở rộng chức năng mà hạn chế sửa đổi mã nguồn hiện có.
- **LSP:** Đảm bảo các lớp có thể thay thế kiểu cơ sở theo đúng hợp đồng.
- **ISP:** Thiết kế các interface tập trung vào từng trách nhiệm.
- **DIP:** Phụ thuộc vào abstraction thay vì implementation cụ thể.

## 6. Kiểm thử

Sử dụng xUnit để kiểm thử các chức năng:

- Kiểm tra tính toán chiết khấu.
- Kiểm tra tạo đơn hàng.
- Kiểm tra dịch vụ bảo hành mở rộng.
- Kiểm tra thông báo trạng thái đơn hàng.

**Kết quả hiện tại:** 6 tests passed, 0 failed.

## 7. Hướng dẫn chạy dự án

1. Cài đặt .NET 10 SDK và Visual Studio.
2. Mở file `CarDealership.slnx`.
3. Build Solution.
4. Chạy kiểm thử bằng lệnh:

```bash
dotnet test
```

## 8. Hướng phát triển

- Bổ sung chức năng quản lý xe và khách hàng.
- Quản lý hợp đồng mua bán ô tô.
- Tích hợp cơ sở dữ liệu.
- Xây dựng giao diện người dùng.
- Bổ sung báo cáo và thống kê doanh thu.

---

**Môn học:** Phát triển phần mềm hướng đối tượng  
**Ngôn ngữ:** C#  
**Nền tảng:** .NET 10.0
