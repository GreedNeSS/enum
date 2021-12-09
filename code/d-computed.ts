enum FileAccess { Read = 1, Write, ReadWrite }

const value1 = FileAccess.Read;
const value2 = FileAccess.Write;
const value3 = FileAccess.ReadWrite;
const value4 = FileAccess[2];

console.dir({ value1, value2, value3, value4 });