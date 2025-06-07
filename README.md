# Ứng dụng Quản lý Bán hàng Sữa Vinamilk

Đây là một ứng dụng quản lý bán hàng được phát triển bằng C# WinForms, sử dụng SQL Server (MSSQL) để quản lý cơ sở dữ liệu và ADO.NET để tương tác với dữ liệu. Ứng dụng được thiết kế để hỗ trợ quá trình bán hàng và quản lý thông tin liên quan đến sản phẩm, nhân viên và khách hàng cho một công ty sữa, có thể là Vinamilk dựa trên các hình ảnh.

## Tính năng chính

Ứng dụng cung cấp các tính năng quản lý cơ bản cho một hệ thống bán hàng:

### 1. Đăng nhập hệ thống

Người dùng cần đăng nhập để truy cập vào các chức năng của ứng dụng.

![SAP Fiori Login Page](/screenshots/Screenshot%202025-06-07%20151121.png)

### 2. Quản lý Sản phẩm

Hiển thị danh sách các sản phẩm sữa, cho phép tìm kiếm và lọc sản phẩm.
Thông tin chi tiết về sản phẩm bao gồm tên sản phẩm, mô tả, nhà sản xuất, đơn vị sử dụng và giá cả.

![Product Management Screen](/screenshots//screenshots/Screenshot%202025-06-07%20151355.png)

### 3. Quản lý Nhân viên

Cho phép quản lý thông tin nhân viên, bao gồm thêm, sửa, xóa nhân viên.
Thông tin chi tiết về nhân viên như tên, địa chỉ, giới tính, ngày sinh, số điện thoại, email, chức vụ, địa chỉ cụ thể và kinh nghiệm.
Có hiển thị ảnh đại diện của nhân viên.

![Employee Management Screen](/screenshots/Screenshot%202025-06-07%20151501.png)

### 4. Quản lý Khách hàng

Quản lý thông tin khách hàng, bao gồm tên khách hàng, địa chỉ, số điện thoại, email và điểm tích lũy.
Cho phép đăng ký khách hàng mới và chỉnh sửa thông tin khách hàng hiện có.

![Customer Management Screen](/screenshots/Screenshot%2025-06-07%20151527.png)

### 5. Lập hóa đơn bán hàng

Giao diện để tạo hóa đơn bán hàng, thêm các sản phẩm vào hóa đơn, hiển thị tổng tiền và chiết khấu.
Cho phép chọn khách hàng và tính toán điểm tích lũy.

![Sales Invoice Creation Screen](/screenshots/Screenshot%202025-06-07%20155742.png)

### 6. Xem và in hóa đơn

Sau khi thanh toán, hóa đơn chi tiết sẽ được tạo ra, hiển thị thông tin công ty, người mua hàng, sản phẩm đã mua, số lượng, đơn giá và tổng tiền.
Hỗ trợ xem lại và in hóa đơn.

![Invoice Printout](/screenshots/Screenshot%202025-06-07%20160600.png)

## Công nghệ sử dụng

* **Ngôn ngữ lập trình:** C#
* **Môi trường phát triển:** .NET Framework (WinForms)
* **Cơ sở dữ liệu:** Microsoft SQL Server (MSSQL)
* **Truy cập dữ liệu:** ADO.NET

## Hướng dẫn cài đặt và chạy ứng dụng

1.  **Cài đặt SQL Server:** Đảm bảo bạn đã cài đặt Microsoft SQL Server trên máy tính của mình.
2.  **Khôi phục cơ sở dữ liệu:**
    * Tạo một cơ sở dữ liệu mới trong SQL Server Management Studio (SSMS).
    * Khôi phục file backup cơ sở dữ liệu (nếu có) hoặc tạo các bảng theo cấu trúc đã định.
    * Cập nhật chuỗi kết nối (connection string) trong ứng dụng C# của bạn để trỏ đến cơ sở dữ liệu này.
3.  **Mở Project trong Visual Studio:** Mở file `.sln` của project bằng Visual Studio.
4.  **Build Project:** Xây dựng project để đảm bảo tất cả các thư viện và phụ thuộc được tải đúng cách.
5.  **Chạy ứng dụng:** Nhấn `F5` hoặc nút "Start" trong Visual Studio để chạy ứng dụng.

## Cấu trúc Project (dự kiến)

* **UI Layer (WinForms):** Chứa các form giao diện người dùng.
* **Business Logic Layer:** Xử lý các nghiệp vụ kinh doanh.
* **Data Access Layer (ADO.NET):** Tương tác với cơ sở dữ liệu (các lớp kết nối, truy vấn dữ liệu).
* **Database:** Các script SQL để tạo bảng, dữ liệu mẫu, và thủ tục lưu trữ (stored procedures) nếu có.

## Đóng góp

Nếu bạn muốn đóng góp vào dự án này, vui lòng fork repository và tạo một pull request.

## Liên hệ

Nếu có bất kỳ câu hỏi hoặc góp ý nào, vui lòng liên hệ.
