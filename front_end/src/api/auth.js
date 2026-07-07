// ============================================================
//  API Configuration - Kết nối Backend C#
//  Sửa BASE_URL thành địa chỉ backend C# của bạn
// ============================================================

const BASE_URL = 'https://localhost:7000/api' // <-- ĐỔI URL BACKEND C# TẠI ĐÂY

/**
 * Đăng nhập người dùng
 * POST /api/auth/login
 * @param {string} identifier - Email hoặc số điện thoại
 * @param {string} password   - Mật khẩu
 * @returns {Promise<{token: string, user: object}>}
 */
export async function loginUser(identifier, password) {
  const response = await fetch(`${BASE_URL}/auth/login`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify({
      Identifier: identifier, // Email hoặc SĐT — đổi key theo yêu cầu backend C#
      Password: password,
    }),
  })

  if (!response.ok) {
    const errorData = await response.json().catch(() => ({}))
    throw new Error(errorData.message || `Lỗi server: ${response.status}`)
  }

  return response.json() // Trả về { token, user, ... }
}

/**
 * Đăng nhập bằng Google (OAuth redirect)
 * Gọi endpoint backend C# xử lý Google OAuth
 */
export function loginWithGoogle() {
  // Backend C# sẽ redirect sang Google OAuth rồi callback về frontend
  window.location.href = `${BASE_URL}/auth/google` // <-- ĐỔI ENDPOINT THEO BACKEND C#
}
