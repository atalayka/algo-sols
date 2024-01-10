function ExpressionMatter([int] $a, [int] $b, [int] $c) {
[int[]]$d = @((($a + $b) * $c), ($a + $b * $c), ($a * $b * $c), ($a * ($b + $c)), ($a + $b + $c))
$e = ($d | Sort-Object -Descending)
$e[0]
}
