# Ứng dụng Quản lý Bán hàng Sữa Vinamilk

Đây là một ứng dụng quản lý bán hàng được phát triển bằng C# WinForms, sử dụng SQL Server (MSSQL) để quản lý cơ sở dữ liệu và ADO.NET để tương tác với dữ liệu. Ứng dụng được thiết kế để hỗ trợ quá trình bán hàng và quản lý thông tin liên quan đến sản phẩm, nhân viên và khách hàng cho một công ty sữa, có thể là Vinamilk dựa trên các hình ảnh.

## Tính năng chính

Ứng dụng cung cấp các tính năng quản lý cơ bản cho một hệ thống bán hàng:

### 1. Đăng nhập hệ thống

Người dùng cần đăng nhập để truy cập vào các chức năng của ứng dụng.

Danh sách tài khoản có trong DB:
| Mã nhân viên | Mật khẩu | Chức vụ         |
|--------------|----------|-----------------|
| nv00000001   | 1        | Admin           |
| nv00000002   | 1        | Bán hàng        |
| nv00000003   | 1        | Kế toán         |
| nv00000004   | 1        | Thu ngân        |
| nv00000005   | 1        | Giao hàng       |
| nv00000006   | 1        | Thủ kho         |
| nv00000007   | 1        | Thực tập sinh   |

![SAP Fiori Login Page](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20151121.png)

### 2. Quản lý Sản phẩm

Hiển thị danh sách các sản phẩm sữa, cho phép tìm kiếm và lọc sản phẩm.
Thông tin chi tiết về sản phẩm bao gồm tên sản phẩm, mô tả, nhà sản xuất, đơn vị sử dụng và giá cả.

![Product Management Screen](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20151355.png)

### 3. Quản lý Nhân viên

Cho phép quản lý thông tin nhân viên, bao gồm thêm, sửa, xóa nhân viên.
Thông tin chi tiết về nhân viên như tên, địa chỉ, giới tính, ngày sinh, số điện thoại, email, chức vụ, địa chỉ cụ thể và kinh nghiệm.
Có hiển thị ảnh đại diện của nhân viên.

![Employee Management Screen](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20151501.png)

### 4. Quản lý Khách hàng

Quản lý thông tin khách hàng, bao gồm tên khách hàng, địa chỉ, số điện thoại, email và điểm tích lũy.
Cho phép đăng ký khách hàng mới và chỉnh sửa thông tin khách hàng hiện có.

![Customer Management Screen](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20151527.png)

### 5. Lập hóa đơn bán hàng

Giao diện để tạo hóa đơn bán hàng, thêm các sản phẩm vào hóa đơn, hiển thị tổng tiền và chiết khấu.
Cho phép chọn khách hàng và tính toán điểm tích lũy.

![Sales Invoice Creation Screen](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20155742.png)

### 6. In hóa đơn

Sau khi thanh toán, hóa đơn chi tiết sẽ được tạo ra, hiển thị thông tin công ty, người mua hàng, sản phẩm đã mua, số lượng, đơn giá và tổng tiền.

![Invoice Printout](/milk-sales-manager/screenshots/Screenshot%202025-06-07%20160600.png)

## Công nghệ sử dụng

* **Ngôn ngữ lập trình:** C#
* **Môi trường phát triển:** .NET Framework (WinForms)
* **Cơ sở dữ liệu:** Microsoft SQL Server (MSSQL)
* **Truy cập dữ liệu:** ADO.NET

## Hướng dẫn cài đặt và chạy ứng dụng

1.  **Clone Repository:**
    Sử dụng Git để clone project về máy tính của bạn:
    ```bash
    git clone https://github.com/chieuvb/milk-sales-manager.git
    ```
    Sau khi clone, bạn sẽ có thư mục `milk-sales-manager` chứa mã nguồn.

2.  **Cài đặt SQL Server:**
    Đảm bảo bạn đã cài đặt Microsoft SQL Server trên máy tính của mình (phiên bản 2012 trở lên được khuyến nghị).

3.  **Khôi phục cơ sở dữ liệu:**
    * Mở SQL Server Management Studio (SSMS).
    * Tạo một cơ sở dữ liệu mới từ file [milk_sales_manager.sql](milk_sales_manager.sql).
    * **Cập nhật chuỗi kết nối (Connection String):** Mở project trong Visual Studio. Tìm file cấu hình `App.config`. Cập nhật chuỗi kết nối để trỏ đến cơ sở dữ liệu SQL Server của bạn:
        ```xml
        <connectionStrings>
           <add name="DBEntities" connectionString="metadata=res://*/models.Model1.csdl|res://*/models.Model1.ssdl|res://*/models.Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=<TEN_SERVER>;initial catalog=<TEN_DATABASE>;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
         </connectionStrings>
        ```
        Thay `TEN_SERVER`, `<TEN_DATABASE>` bằng tên server SQL, database của bạn.

4.  **Mở Project trong Visual Studio:**
    Mở file `milk-sales-manager.sln` trong thư mục gốc của project bằng Visual Studio (phiên bản 2022 được khuyến nghị).

5.  **Cài đặt các gói NuGet:**
    Cài đặt [EntityFramework (6.5.1)](https://www.nuget.org/packages/EntityFramework/6.5.1)

6.  **Build Project:**
    Trong Visual Studio, chọn `Build` -> `Build Solution` (hoặc nhấn `Ctrl+Shift+B`) để biên dịch project và đảm bảo không có lỗi.

7.  **Chạy ứng dụng:**
    Nhấn `F5` hoặc nút "Start" trong Visual Studio để chạy ứng dụng.

## Cấu trúc Project

* **controls:** Chứa các form giao diện người dùng.
* **models:** Chứa model ADO.NET.
* **media:** Chứa file icons UI.
* **modules:** Chứa các module tiện ích.
* **screenshots:** Chứa file ảnh chụp mà hình ứng dụng.

## Đóng góp

Nếu bạn muốn đóng góp vào dự án này, vui lòng fork repository và tạo một pull request.

## Liên hệ

Nếu có bất kỳ câu hỏi hoặc góp ý nào, vui lòng liên hệ.
