enum FileAccess { Read = 1, Write = 2, ReadWrite = 3 }

const value1 = FileAccess.Read;
const value2 = FileAccess.Write;
const value3 = FileAccess.ReadWrite;
const value4 = FileAccess[2];

console.dir({ value1, value2, value3, value4 });