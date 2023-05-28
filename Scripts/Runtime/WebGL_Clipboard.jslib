mergeInto(LibraryManager.library, {

  CopyText: function (str) {
    navigator.clipboard.writeText(UTF8ToString(str));
  }

});