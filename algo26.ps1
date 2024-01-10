function CheckForFactor([int] $base, [int] $factor) {
  if ($base % $factor -eq 0) {
    return $true
  } else {
    return $false
  }
}