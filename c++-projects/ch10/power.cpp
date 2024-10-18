
namespace {
    double compute(double x, unsigned n) {
        return n == 0 ? 1.0 : x * compute(x, n - 1);
    }
}

double power(double x, int n) {
    return n >= 0 ? compute(x, static_cast<unsigned>(n))
    : 1.0 / compute(x, static_cast<unsigned>(-n));

}
